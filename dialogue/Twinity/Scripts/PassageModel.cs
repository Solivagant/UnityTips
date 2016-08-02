using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class PassageModel : Singleton<PassageModel>
{
	public Dictionary<int, Passage> passages;
	public int currentPassage = 1;

	public List<Link> currentLinks = new List<Link>();

	public Passage GetCurrentPassage()
	{
		return passages[currentPassage];
	}

	public void Start()
	{
		currentPassage = 1;
		currentLinks = GetCurrentPassage().links;
	}

	public string GetCurrent()
	{
		return GetCurrentPassage().text;
	}

	public void Advance()
	{
		if(GetCurrentPassage().links.Count < 1)
        {
            throw new Exception("Can't advance");
        }
		else if(GetCurrentPassage().links.Count > 1)
        {
			throw new Exception("Can't advance, you must choose");
        }

		currentPassage = passages[GetCurrentPassage().links[0].pid].pid;
		currentLinks = GetCurrentPassage().links;
    }

	public void Choose(int option)
    {
		currentPassage = passages[option].pid;
		currentLinks = GetCurrentPassage().links;
    }
}
