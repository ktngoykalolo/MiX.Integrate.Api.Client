﻿using MiX.Integrate.Shared.Constants;
using MiX.Integrate.Shared.Entities.DeviceCommands;
using System.Threading.Tasks;
using MiX.Integrate.Api.Client.Base;
using MiX.Integrate.API.Client.Base;
using System.Net.Http;

namespace MiX.Integrate.Api.Client
{
	public class DeviceCommandsClient : BaseClient, IDeviceCommandsClient
	{

		public DeviceCommandsClient(string url, bool setTestRequestHeader = false) : base(url, setTestRequestHeader) { }
		public DeviceCommandsClient(string url, IdServerResourceOwnerClientSettings settings, bool setTestRequestHeader = false) : base(url, settings, setTestRequestHeader) { }

		public async Task<long> SendPositionRequestMessageAsync(long groupId, long assetId, MessageTransport? preferredTransport = null)
		{
			IHttpRestRequest request = GetRequest(APIControllerRoutes.DEVICECOMMANDSCONTROLLER.SENDPOSITIONREQUESTMESSAGE, HttpMethod.Get);
			request.AddUrlSegment("groupId:long", groupId.ToString());
			request.AddUrlSegment("assetId:long", assetId.ToString());
			if (preferredTransport.HasValue) request.AddQueryParameter("preferredTransport", preferredTransport.ToString());
			IHttpRestResponse<long> response = await ExecuteAsync<long>(request).ConfigureAwait(false);
			return response.Data;
		}

		public async Task<long> SendRelayCommandAsync(long groupId, long assetId, uint relayDrive, uint relayState, MessageTransport? preferredTransport = null)
		{
			IHttpRestRequest request = GetRequest(APIControllerRoutes.DEVICECOMMANDSCONTROLLER.SENDRELAYCOMMAND, HttpMethod.Get);
			request.AddUrlSegment("groupId:long", groupId.ToString());
			request.AddUrlSegment("assetId:long", assetId.ToString());
			request.AddUrlSegment("relayDrive", relayDrive.ToString());
			request.AddUrlSegment("relayState", relayState.ToString());
			if (preferredTransport.HasValue) request.AddQueryParameter("preferredTransport", preferredTransport.ToString());
			IHttpRestResponse<long> response = await ExecuteAsync<long>(request).ConfigureAwait(false);
			return response.Data;
		}

		public async Task<long> SendTrackingRequestAsync(long groupId, long assetId, uint intervalSeconds, uint durationSeconds, MessageTransport? preferredTransport = null)
		{
			IHttpRestRequest request = GetRequest(APIControllerRoutes.DEVICECOMMANDSCONTROLLER.SENDTRACKINGREQUEST, HttpMethod.Get);
			request.AddUrlSegment("groupId:long", groupId.ToString());
			request.AddUrlSegment("assetId:long", assetId.ToString());
			request.AddUrlSegment("intervalSeconds", intervalSeconds.ToString());
			request.AddUrlSegment("durationSeconds", durationSeconds.ToString());
			if (preferredTransport.HasValue) request.AddQueryParameter("preferredTransport", preferredTransport.ToString());
			IHttpRestResponse<long> response = await ExecuteAsync<long>(request).ConfigureAwait(false);
			return response.Data;
		}

		public async Task<long> SendStopTrackingRequestAsync(long groupId, long assetId, MessageTransport? preferredTransport = null)
		{
			IHttpRestRequest request = GetRequest(APIControllerRoutes.DEVICECOMMANDSCONTROLLER.SENDSTOPTRACKINGREQUEST, HttpMethod.Get);
			request.AddUrlSegment("groupId:long", groupId.ToString());
			request.AddUrlSegment("assetId:long", assetId.ToString());
			if (preferredTransport.HasValue) request.AddQueryParameter("preferredTransport", preferredTransport.ToString());
			IHttpRestResponse<long> response = await ExecuteAsync<long>(request).ConfigureAwait(false);
			return response.Data;
		}

		public async Task<long> SendProgressiveShutdownCommandAsync(long groupId, long assetId, uint relayDrive, MessageTransport? preferredTransport = null)
		{
			IHttpRestRequest request = GetRequest(APIControllerRoutes.DEVICECOMMANDSCONTROLLER.SENDPROGRESSIVESHUTDOWNCOMMAND, HttpMethod.Get);
			request.AddUrlSegment("groupId:long", groupId.ToString());
			request.AddUrlSegment("assetId:long", assetId.ToString());
			request.AddUrlSegment("relayDrive", relayDrive.ToString());
			if (preferredTransport.HasValue) request.AddQueryParameter("preferredTransport", preferredTransport.ToString());
			IHttpRestResponse<long> response = await ExecuteAsync<long>(request).ConfigureAwait(false);
			return response.Data;
		}

		public async Task<long> SendDisarmUnitMessageAsync(long groupId, long assetId, MessageTransport? preferredTransport = null)
		{
			IHttpRestRequest request = GetRequest(APIControllerRoutes.DEVICECOMMANDSCONTROLLER.SENDDISARMUNITMESSAGE, HttpMethod.Get);
			request.AddUrlSegment("groupId:long", groupId.ToString());
			request.AddUrlSegment("assetId:long", assetId.ToString());
			if (preferredTransport.HasValue) request.AddQueryParameter("preferredTransport", preferredTransport.ToString());
			IHttpRestResponse<long> response = await ExecuteAsync<long>(request).ConfigureAwait(false);
			return response.Data;
		}

		public async Task<long> SendFreeTextMessageAsync(string message, long groupId, long assetId, MessageTransport? preferredTransport = null)
		{
			IHttpRestRequest request = GetRequest(APIControllerRoutes.DEVICECOMMANDSCONTROLLER.SENDFREETEXTMESSAGE, HttpMethod.Post);
			request.AddUrlSegment("groupId:long", groupId.ToString());
			request.AddUrlSegment("assetId:long", assetId.ToString());
			if (preferredTransport.HasValue) request.AddQueryParameter("preferredTransport", preferredTransport.ToString());
			request.AddJsonBody(message);
			IHttpRestResponse<long> response = await ExecuteAsync<long>(request).ConfigureAwait(false);
			return response.Data;
		}

		public async Task<long> SendSetAcronymCommandAsync(long groupId, long assetId, uint? param1 = null, uint? param2 = null, uint? param3 = null, MessageTransport? preferredTransport = null)
		{
			IHttpRestRequest request = GetRequest(APIControllerRoutes.DEVICECOMMANDSCONTROLLER.SENDSETACRONYMCOMMAND, HttpMethod.Get);
			request.AddUrlSegment("groupId:long", groupId.ToString());
			request.AddUrlSegment("assetId:long", assetId.ToString());
			request.AddUrlSegment("param1", param1.HasValue ? param1.Value.ToString() : "0");
			request.AddUrlSegment("param2", param2.HasValue ? param2.Value.ToString() : "0");
			request.AddUrlSegment("param3", param3.HasValue ? param3.Value.ToString() : "0");
			if (preferredTransport.HasValue) request.AddQueryParameter("preferredTransport", preferredTransport.ToString());
			IHttpRestResponse<long> response = await ExecuteAsync<long>(request).ConfigureAwait(false);
			return response.Data;
		}



		public long SendPositionRequestMessage(long groupId, long assetId, MessageTransport? preferredTransport = null)
		{
			IHttpRestRequest request = GetRequest(APIControllerRoutes.DEVICECOMMANDSCONTROLLER.SENDPOSITIONREQUESTMESSAGE, HttpMethod.Get);
			request.AddUrlSegment("groupId:long", groupId.ToString());
			request.AddUrlSegment("assetId:long", assetId.ToString());
			if (preferredTransport.HasValue) request.AddQueryParameter("preferredTransport", preferredTransport.ToString());
			IHttpRestResponse<long> response = Execute<long>(request);
			return response.Data;
		}

		public long SendRelayCommand(long groupId, long assetId, uint relayDrive, uint relayState, MessageTransport? preferredTransport = null)
		{
			IHttpRestRequest request = GetRequest(APIControllerRoutes.DEVICECOMMANDSCONTROLLER.SENDRELAYCOMMAND, HttpMethod.Get);
			request.AddUrlSegment("groupId:long", groupId.ToString());
			request.AddUrlSegment("assetId:long", assetId.ToString());
			request.AddUrlSegment("relayDrive", relayDrive.ToString());
			request.AddUrlSegment("relayState", relayState.ToString());
			if (preferredTransport.HasValue) request.AddQueryParameter("preferredTransport", preferredTransport.ToString());
			IHttpRestResponse<long> response = Execute<long>(request);
			return response.Data;
		}

		public long SendTrackingRequest(long groupId, long assetId, uint intervalSeconds, uint durationSeconds, MessageTransport? preferredTransport = null)
		{
			IHttpRestRequest request = GetRequest(APIControllerRoutes.DEVICECOMMANDSCONTROLLER.SENDTRACKINGREQUEST, HttpMethod.Get);
			request.AddUrlSegment("groupId:long", groupId.ToString());
			request.AddUrlSegment("assetId:long", assetId.ToString());
			request.AddUrlSegment("intervalSeconds", intervalSeconds.ToString());
			request.AddUrlSegment("durationSeconds", durationSeconds.ToString());
			if (preferredTransport.HasValue) request.AddQueryParameter("preferredTransport", preferredTransport.ToString());
			IHttpRestResponse<long> response = Execute<long>(request);
			return response.Data;
		}

		public long SendStopTrackingRequest(long groupId, long assetId, MessageTransport? preferredTransport = null)
		{
			IHttpRestRequest request = GetRequest(APIControllerRoutes.DEVICECOMMANDSCONTROLLER.SENDSTOPTRACKINGREQUEST, HttpMethod.Get);
			request.AddUrlSegment("groupId:long", groupId.ToString());
			request.AddUrlSegment("assetId:long", assetId.ToString());
			if (preferredTransport.HasValue) request.AddQueryParameter("preferredTransport", preferredTransport.ToString());
			IHttpRestResponse<long> response = Execute<long>(request);
			return response.Data;
		}

		public long SendProgressiveShutdownCommand(long groupId, long assetId, uint relayDrive, MessageTransport? preferredTransport = null)
		{
			IHttpRestRequest request = GetRequest(APIControllerRoutes.DEVICECOMMANDSCONTROLLER.SENDPROGRESSIVESHUTDOWNCOMMAND, HttpMethod.Get);
			request.AddUrlSegment("groupId:long", groupId.ToString());
			request.AddUrlSegment("assetId:long", assetId.ToString());
			request.AddUrlSegment("relayDrive", relayDrive.ToString());
			if (preferredTransport.HasValue) request.AddQueryParameter("preferredTransport", preferredTransport.ToString());
			IHttpRestResponse<long> response = Execute<long>(request);
			return response.Data;
		}

		public long SendDisarmUnitMessage(long groupId, long assetId, MessageTransport? preferredTransport = null)
		{
			IHttpRestRequest request = GetRequest(APIControllerRoutes.DEVICECOMMANDSCONTROLLER.SENDDISARMUNITMESSAGE, HttpMethod.Get);
			request.AddUrlSegment("groupId:long", groupId.ToString());
			request.AddUrlSegment("assetId:long", assetId.ToString());
			if (preferredTransport.HasValue) request.AddQueryParameter("preferredTransport", preferredTransport.ToString());
			IHttpRestResponse<long> response = Execute<long>(request);
			return response.Data;
		}

		public long SendFreeTextMessage(string message, long groupId, long assetId, MessageTransport? preferredTransport = null)
		{
			IHttpRestRequest request = GetRequest(APIControllerRoutes.DEVICECOMMANDSCONTROLLER.SENDFREETEXTMESSAGE, HttpMethod.Post);
			request.AddUrlSegment("groupId:long", groupId.ToString());
			request.AddUrlSegment("assetId:long", assetId.ToString());
			if (preferredTransport.HasValue) request.AddQueryParameter("preferredTransport", preferredTransport.ToString());
			request.AddJsonBody(message);
			IHttpRestResponse<long> response = Execute<long>(request);
			return response.Data;
		}

		public long SendSetAcronymCommand(long groupId, long assetId, uint? param1 = null, uint? param2 = null, uint? param3 = null, MessageTransport? preferredTransport = null)
		{
			IHttpRestRequest request = GetRequest(APIControllerRoutes.DEVICECOMMANDSCONTROLLER.SENDSETACRONYMCOMMAND, HttpMethod.Get);
			request.AddUrlSegment("groupId:long", groupId.ToString());
			request.AddUrlSegment("assetId:long", assetId.ToString());
			request.AddUrlSegment("param1", param1.HasValue ? param1.Value.ToString() : "0");
			request.AddUrlSegment("param2", param2.HasValue ? param2.Value.ToString() : "0");
			request.AddUrlSegment("param3", param3.HasValue ? param3.Value.ToString() : "0");
			if (preferredTransport.HasValue) request.AddQueryParameter("preferredTransport", preferredTransport.ToString());
			IHttpRestResponse<long> response = Execute<long>(request);
			return response.Data;
		}
	}
}
