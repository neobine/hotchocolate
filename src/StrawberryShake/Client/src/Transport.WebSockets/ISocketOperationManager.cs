using System;
using System.Threading;
using System.Threading.Tasks;
using StrawberryShake.Transport.WebSockets.Messages;

namespace StrawberryShake.Transport.Subscriptions
{
    public interface ISocketOperationManager
        : IAsyncDisposable
    {
        Task<SocketOperation> StartOperationAsync(
            OperationRequest request,
            CancellationToken cancellationToken = default);

        Task StopOperationAsync(
            string operationId,
            CancellationToken cancellationToken = default);

        ValueTask ReceiveMessage(
            OperationMessage message,
            CancellationToken cancellationToken = default);
    }
}