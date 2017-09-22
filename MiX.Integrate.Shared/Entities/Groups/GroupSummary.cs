﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiX.Integrate.Shared.Entities.Groups
{
  /// <summary>Summary information for a group in the organisation hierarchy</summary>
	public class GroupSummary
	{
		public GroupSummary() { }
		public GroupSummary(long groupId, string name, GroupType type)
		{
			GroupId = groupId;
			Name = name;
			Type = type;
		}
		/// <summary>The unique identifier of the group</summary>
		public long GroupId { get; set; }

		/// <summary>The name of the group</summary>
		public string Name { get; set; }

		/// <summary>The <see cref="GroupType"/> of the group</summary>
		public GroupType Type { get; set; }
		private List<GroupSummary> _subGroups = new List<GroupSummary>();
		public List<GroupSummary> SubGroups
		{
			get { return _subGroups; }
			set { _subGroups = value; }
		}
	}
}
