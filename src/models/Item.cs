using System.Xml.Serialization;

public class Item
{
    [XmlElement("name")]
    public string? Name { get; set; }

    [XmlElement("internalName")]
    public string? InternalName { get; set; }

    [XmlElement("category")]
    public string? Category { get; set; }

    [XmlElement("type")]
    public string? Type { get; set; }

    [XmlElement("icon100")]
    public string? Icon100 { get; set; }

    [XmlElement("icon80")]
    public string? Icon80 { get; set; }

    [XmlElement("description")]
    public string? Description { get; set; }

    [XmlElement("developer")]
    public string? Developer { get; set; }

    [XmlElement("developerLink")]
    public string? DeveloperLink { get; set; }

    [XmlElement("fwVersion")]
    public string? FwVersion { get; set; }

    [XmlElement("version")]
    public string? Version { get; set; }

    [XmlArray("platform")]
    [XmlArrayItem("platformID")]
    public List<Platform>? Platforms { get; set; }

    [XmlElement("snapshot")]
    public string? Snapshot { get; set; }

    [XmlElement("tutorialLink")]
    public string? TutorialLink { get; set; }

    [XmlElement("forumLink")]
    public string? ForumLink { get; set; }
}
