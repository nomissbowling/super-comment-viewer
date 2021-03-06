﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var twicasCommentModel = TwicasCommentModel.FromJson(jsonString);

using System.Collections.Generic;
using System.Text.Json.Serialization;

public class Author
{
    [JsonIgnore]
    public string id { get; set; }
    [JsonInclude]
    public string name { get; set; }
    [JsonIgnore]
    public string screenName { get; set; }
    [JsonInclude]
    public string profileImage { get; set; }
    [JsonIgnore]
    public int grade { get; set; }
}

public class TwicasCommentModel
{
    [JsonIgnore]
    public string type { get; set; }
    [JsonIgnore]
    public long id { get; set; }
    [JsonInclude]
    public string message { get; set; }
    [JsonIgnore]
    public long createdAt { get; set; }
    [JsonInclude]
    public Author author { get; set; }
    [JsonIgnore]
    public int numComments { get; set; }


    public override int GetHashCode()
    {
        int hash = 31;
        hash = hash * this.message.GetHashCode() + 31;
        hash = hash * this.author.name.GetHashCode() + 31;
        hash = hash * this.author.profileImage.GetHashCode() + 31;
        return hash;
    }


    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        if (!(obj is TwicasCommentModel)) return false;
        var tar = (obj as TwicasCommentModel);
        if (!tar.message.Equals(this.message)) return false;
        if (!tar.author.name.Equals(this.author.name)) return false;
        if (!tar.author.profileImage.Equals(this.author.profileImage)) return false;
        return true;
    }
}
