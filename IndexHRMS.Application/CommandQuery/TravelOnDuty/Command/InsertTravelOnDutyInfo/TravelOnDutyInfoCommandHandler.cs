using AutoMapper;
using IndexHRMS.Application.Helper;
using IndexHRMS.Application.Interfaces;
using IndexHRMS.Entity.Entities;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using System.Security.Claims;
using System.Text.Json;
using System.Net.Sockets;

namespace IndexHRMS.Application.CommandQuery.TravelOnDuty.Command.InsertTravelOnDutyInfo
{
	public class TravelOnDutyInfoCommandHandler : IRequestHandler<TravelOnDutyInfoCommand, Message>
	{
		private readonly IMapper _mapper;
		private readonly ITravelOnDutyRepository _iTravelOnDutyRepository;
		private readonly ITravelOnDutyInfoRepository _ITravelOnDutyInfoRepository;
		private readonly IHttpContextAccessor _iHttpContextAccessor;
		public static IHostingEnvironment _environment;
		public TravelOnDutyInfoCommandHandler(
			IMapper iMapper,
			ITravelOnDutyRepository iTravelOnDutyRepository,
			IHttpContextAccessor iHttpContextAccessor,
			IHostingEnvironment environment,
			ITravelOnDutyInfoRepository ITravelOnDutyInfoRepository
			)
		{
			_mapper = iMapper;
			_iTravelOnDutyRepository = iTravelOnDutyRepository;
			_iHttpContextAccessor = iHttpContextAccessor;
			_environment = environment;
			_ITravelOnDutyInfoRepository = ITravelOnDutyInfoRepository;
		}
		public async Task<Message> Handle(TravelOnDutyInfoCommand model, CancellationToken cancellationToken)
		{
			var FileUrl= new List<string>();
			if (model.Attachments != null)
			{
				foreach (var file in model.Attachments)
				{
					var extension = Path.GetExtension(file
						.FileName)?.Trim().ToLower();
					if (extension == ".jpg" ||
						extension == ".PNG" ||
						extension == ".doc" ||
						extension == ".xls" ||
						extension == ".xlsx" ||
						extension == ".docx" ||
						extension == ".pdf" ||
						extension == ".PNG"
						)
					{

						var fileName = DateTime.Now.ToString("yyyyMMddhhmmss") + Path.GetExtension(file.FileName)?.Trim().ToLower();
						string path = Path.Combine(_environment.ContentRootPath, "Files\\" + file.FileName);
						if (!Directory.Exists(_environment.ContentRootPath + "\\Files\\"))
						{
							Directory.CreateDirectory(_environment.ContentRootPath + "\\Files\\");
						}
						using (var stream = new FileStream(path, FileMode.Create))
						{
							await file.CopyToAsync(stream);
							FileUrl.Add(path);
						}
					}
					else
						throw new Exception("Please upload .jpg, PNG, gif, doc, xls file only.");
				}
			}

			var message = new Message();
			var TravelOnDutyInfo = new TravelOnDutyInfo();
			var currentUser = _iHttpContextAccessor.HttpContext.User;
			var userId = currentUser.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).Select(x => x.Value).FirstOrDefault();
			TravelOnDutyInfo.FileUrl = JsonSerializer.Serialize(FileUrl);
			TravelOnDutyInfo.AddedDate = Convert.ToDateTime(DateTime.Now);
			TravelOnDutyInfo.AddedBy = userId;
			TravelOnDutyInfo.Latitude = model.Latitude;
			TravelOnDutyInfo.Longitude = model.Longitude;
			TravelOnDutyInfo.Active = true;
			TravelOnDutyInfo.Address = model.Address;
			TravelOnDutyInfo.TravelOnDutyId = model.TravelOnDutyId;
			TravelOnDutyInfo.AddedFromIP = GetLocalIPAddress();
			TravelOnDutyInfo.Id = await GetTravelOnDutyPk();
			try
			{
				var details = await _ITravelOnDutyInfoRepository.AddAsync(TravelOnDutyInfo);
				var insertedData = await _ITravelOnDutyInfoRepository.GetByIdAsync(details.Id);
				if (details.Id is not null)
				{
					message = new Message()
					{
						Data = insertedData,
						StatusCode = Convert.ToInt32(HttpStatusCode.OK),
						StatusMessage = StringHelper.InsertTODInfoMessage
					};
				}
				return message;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		private async Task<string> GetTravelOnDutyPk()
		{
			try
			{
				var id = await _ITravelOnDutyInfoRepository.GetIdAsync();
				return id;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public static string GetLocalIPAddress()
		{
			var host = Dns.GetHostEntry(Dns.GetHostName());
			foreach (var ip in host.AddressList)
			{
				if (ip.AddressFamily == AddressFamily.InterNetwork)
				{
					return ip.ToString();
				}
			}
			throw new Exception("No network adapters with an IPv4 address in the system!");
		}
	}

	
}
