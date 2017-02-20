using System;
using System.Collections.Generic;

namespace StudySesh.Models
{
	public class Sesh
	{
		private DateTime endDateField;
		private Location locationField;
		private string ownerField;
		private List<string> participants;
		private DateTime startDateField;
		private string subjectField;
		private string topicField;


		public string subject
		{
			get
			{
				return subjectField;
			}
			set
			{
				subjectField = value;
			}
		}

		public string topic
		{
			get
			{
				return topicField;
			}
			set
			{
				topicField = value;
			}
		}

		public Sesh()
		{
		}
	}
}
