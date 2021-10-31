﻿using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using OzonEdu.MerchandiseService.HttpModels;

namespace OzonEdu.MerchandiseService.HttpClient
{
    public class MerchandiseHttpClient : IMerchandiseHttpClient
    {
        private readonly System.Net.Http.HttpClient _httpClient;

        public async Task<MerchItemRequest> RequestMerch(MerchItemRequest itemRequest, CancellationToken token)
        {
            var data = new StringContent(JsonSerializer.Serialize(itemRequest), Encoding.UTF8, "application/json");
            using var response = await _httpClient.PostAsync("v1/api/merch", data, token);
            return await response.Content.ReadFromJsonAsync<MerchItemRequest>(cancellationToken: token);
        }

        public async Task<MerchItemResponse> GetRequestedMerchInfo(long id, CancellationToken token)
        {
            using var response = await _httpClient.GetAsync($"v1/api/stocks/{id}", token);
            var body = await response.Content.ReadAsStringAsync(token);
            return JsonSerializer.Deserialize<MerchItemResponse>(body);
        }
    }
}