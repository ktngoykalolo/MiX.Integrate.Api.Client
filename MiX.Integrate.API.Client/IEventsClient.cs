﻿using System;
using System.Collections.Generic;

using MiX.Integrate.Shared.Entities.Events;
using System.Threading.Tasks;

namespace MiX.Integrate.Api.Client
{
	public interface IEventsClient : IBaseClient
	{
		IList<Event> GetLatestForAssets(List<long> assetIds, byte quantity = 1, DateTime? cachedSince = null);
		Task<IList<Event>> GetLatestForAssetsAsync(List<long> assetIds, byte quantity = 1, DateTime? cachedSince = null);
		IList<Event> GetLatestForDrivers(List<long> driverIds, byte quantity = 1, DateTime? cachedSince = null);
		Task<IList<Event>> GetLatestForDriversAsync(List<long> driverIds, byte quantity = 1, DateTime? cachedSince = null);
		IList<Event> GetLatestForGroups(List<long> groupIds, string entityType, byte quantity = 1, DateTime? cachedSince = null);
		Task<IList<Event>> GetLatestForGroupsAsync(List<long> groupIds, string entityType, byte quantity = 1, DateTime? cachedSince = null);
		IList<Event> GetRangeForAssets(List<long> assetIds, DateTime from, DateTime to, List<long> eventTypeIds = null);
		Task<IList<Event>> GetRangeForAssetsAsync(List<long> assetIds, DateTime from, DateTime to, List<long> eventTypeIds = null);
		IList<Event> GetRangeForDrivers(List<long> driverIds, DateTime from, DateTime to, List<long> eventTypeIds = null);
		Task<IList<Event>> GetRangeForDriversAsync(List<long> driverIds, DateTime from, DateTime to, List<long> eventTypeIds = null);
		IList<Event> GetRangeForGroups(List<long> groupIds, string entityType, DateTime from, DateTime to, List<long> eventTypeIds = null);
		Task<IList<Event>> GetRangeForGroupsAsync(List<long> groupIds, string entityType, DateTime from, DateTime to, List<long> eventTypeIds = null);
		IList<Event> GetSinceForAssets(List<long> assetIds, DateTime since, byte quantity, List<long> eventTypeIds = null);
		Task<IList<Event>> GetSinceForAssetsAsync(List<long> assetIds, DateTime since, byte quantity, List<long> eventTypeIds = null);
		IList<Event> GetSinceForDrivers(List<long> driverIds, DateTime since, byte quantity, List<long> eventTypeIds = null);
		Task<IList<Event>> GetSinceForDriversAsync(List<long> driverIds, DateTime since, byte quantity, List<long> eventTypeIds = null);
		IList<Event> GetSinceForGroups(List<long> groupIds, string entityType, DateTime since, List<long> eventTypeIds = null);
		Task<IList<Event>> GetSinceForGroupsAsync(List<long> groupIds, string entityType, DateTime since, List<long> eventTypeIds = null);

	}
}