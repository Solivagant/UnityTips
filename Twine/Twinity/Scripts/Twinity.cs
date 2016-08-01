using UnityEngine;
using System.Collections;
using System;
using SimpleJSON;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Link{
	public Link(string text, int pid){
		this.text = text;
		this.pid = pid;
	}

	public string text;
	public int pid;
}

public class Passage{
	public int pid;
	public string text;
	public List<Link> links;
}

public static class Twinity{
	const string REGEX_LINK_LEFT = @"/\[\[/g";
	const string REGEX_LINK_RIGHT = @"/\]\]/g";

	const string PASSAGES = "passages";
	const string TEXT = "text";
	const string LINKS = "links";

	public static void Parse(string file){
		var adventure = JSON.Parse(file);

		Dictionary<int,Passage> passages = new Dictionary<int,Passage>();

		var counter = 0;

		for(var i = 0; i < adventure[PASSAGES].Count; i++){
			var passage = adventure[PASSAGES][i];
			string text = passage[TEXT];

			if(text.IndexOf('[') != -1){
				text = text.Substring(0, text.IndexOf('['));
			}

			Passage p = new Passage();
			p.pid = passage["pid"].AsInt;
			p.text = text;
			p.links = new List<Link>();

			Regex regLeft = new Regex(REGEX_LINK_LEFT);
			Regex regRight = new Regex(REGEX_LINK_RIGHT);

			if(passage[LINKS] != null){

				for(var j = 0; j < passage[LINKS].Count; j++){
					var link = passage[LINKS][j];

					var linkText = regLeft.Replace(link["name"].ToString(), "");
					linkText = regRight.Replace(linkText, "");

					p.links.Add(new Link(linkText, link["pid"].AsInt));
				}

				if(passage[LINKS].Count == 1){
					if(counter == 3){
						counter = 0;
						int newPid = passage[LINKS][0]["pid"].AsInt;
						p.links.Add(new Link("More", newPid));
					}
					counter++;
				} else{
					counter = 0;
				}
			}

			passages.Add(p.pid, p);
		}

		PassageModel.Instance.passages = passages;

		foreach(KeyValuePair<int, Passage> kvp in passages){
			Passage value = kvp.Value;
		}
	}
}

