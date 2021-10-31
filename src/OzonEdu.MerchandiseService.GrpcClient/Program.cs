using System;
using System.Threading;
using Grpc.Net.Client;
using OzonEdu.MerchandiseService.Grpc;


using var channel = GrpcChannel.ForAddress("https://localhost:5001");
var client = new MerchandiseServiceGrpc.MerchandiseServiceGrpcClient(channel);

var item = client.RequestMerchandiseItem(
    new RequestMerchandiseItemRequest() {ItemName = "T-Shirt"}, cancellationToken: CancellationToken.None);

var info = client.GetRequestMerchandiseInfo(
    new RequestMerchandiseItemRequest() {ItemName = "T-Shirt"}, cancellationToken: CancellationToken.None);