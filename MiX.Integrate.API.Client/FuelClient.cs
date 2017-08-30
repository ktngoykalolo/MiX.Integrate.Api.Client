﻿using MiX.Integrate.Api.Client.Base;
using MiX.Integrate.API.Client.Base;
using MiX.Integrate.Shared.Constants;
using MiX.Integrate.Shared.Entities.Fuel;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MiX.Integrate.Api.Client
{
	public class FuelClient : BaseClient, IFuelClient
	{
		public FuelClient(string url, bool setTestRequestHeader = false) : base(url, setTestRequestHeader) { }
		public FuelClient(string url, IdServerResourceOwnerClientSettings settings, bool setTestRequestHeader = false) : base(url, settings, setTestRequestHeader) { }

	  public async Task<IList<FuelTransaction>> GetFuelByDateRangeForGroupAsync(long organisationId, DateTime from, DateTime to)
    {
			IHttpRestRequest request = GetRequest(APIControllerRoutes.FUELCONTROLLER.GETFUELBYDATERANGEFORGROUP, HttpMethod.Get);
			request.AddUrlSegment("organisationId:long", organisationId.ToString());
      request.AddUrlSegment("from", from.ToUniversalTime().ToString(DataFormats.DateTime_Format));
      request.AddUrlSegment("to", to.ToUniversalTime().ToString(DataFormats.DateTime_Format));
			IHttpRestResponse<List<FuelTransaction>> response = await ExecuteAsync<List<FuelTransaction>>(request).ConfigureAwait(false);
			return response.Data;
		}

	  public IList<FuelTransaction> GetFuelByDateRangeForGroup(long organisationId, DateTime from, DateTime to)
    {
      IHttpRestRequest request = GetRequest(APIControllerRoutes.FUELCONTROLLER.GETFUELBYDATERANGEFORGROUP, HttpMethod.Get);
      request.AddUrlSegment("organisationId:long", organisationId.ToString());
      request.AddUrlSegment("from", from.ToUniversalTime().ToString(DataFormats.DateTime_Format));
      request.AddUrlSegment("to", to.ToUniversalTime().ToString(DataFormats.DateTime_Format));
      IHttpRestResponse<List<FuelTransaction>> response = Execute<List<FuelTransaction>>(request);
      return response.Data;
    }

	}
}
