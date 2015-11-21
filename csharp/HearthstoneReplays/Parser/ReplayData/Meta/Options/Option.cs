﻿#region

using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

#endregion

namespace HearthstoneReplays.Parser.ReplayData.Meta.Options
{
	[XmlRoot("Option")]
	public class Option : GameData
	{
		[XmlAttribute("index")]
		public int Index { get; set; }

		[XmlAttribute("type")]
		public int Type { get; set; }

		[XmlAttribute("entity"), DefaultValue(0)]
		public int Entity { get; set; }

		[XmlElement("SubOption", typeof(SubOption))]
		[XmlElement("Target", typeof(Target))]
		public List<OptionItem> OptionItems { get; set; }
	}
}