using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("word")]
    public string word { get; set; }

    [JsonProperty("isAlphagram")]
    public bool isAlphagram { get; set; }

    [JsonProperty("sortedForm")]
    public string sortedForm { get; set; }

    [JsonProperty("isPalindrome")]
    public bool isPalindrome { get; set; }

    [JsonProperty("hasAnagram")]
    public bool hasAnagram { get; set; }

    [JsonProperty("isIsogram")]
    public bool isIsogram { get; set; }

    [JsonProperty("isPangramCandidate")]
    public bool isPangramCandidate { get; set; }

    [JsonProperty("isScrabbleValid")]
    public bool isScrabbleValid { get; set; }

    [JsonProperty("canBePalindromeAnagram")]
    public bool canBePalindromeAnagram { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
