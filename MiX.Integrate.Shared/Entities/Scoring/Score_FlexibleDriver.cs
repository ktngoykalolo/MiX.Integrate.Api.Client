﻿using System;
using System.Collections.Generic;

namespace MiX.Integrate.Shared.Entities.Scoring
{
	public class Score_FlexibleDriver
	{
		public decimal SiteTotalScore { get; set; }
		public List<PenaltyScoreByEventType> EventPenaltyScores { get; set; }
		public bool IsScored { get; set; }
		public decimal TotalScore { get; set; }
		public int SiteRank { get; set; }
		public int OrganisationRank { get; set; }
		public decimal TripsMaxSpeed { get; set; }
		public bool SiteIsScored { get; set; }
		public decimal TripsDrivingTime { get; set; }
		public decimal TripsDistance { get; set; }
		public int TripsCount { get; set; }
		public string UnitOfMeasure { get; set; }
		public long DriverID { get; set; }
		public long SiteId { get; set; }
		public string Period { get; set; }
		public DateTime DateKey { get; set; }
		public decimal TripsDuration { get; set; }
		public List<PenaltyScoreByEventType> SitePointsPerEventTypes { get; set; }
	}
}
