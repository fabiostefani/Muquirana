using fabiostefani.io.Muquirana.Cadastros.Data;
using Microsoft.Extensions.DependencyInjection;

namespace fabiostefani.io.Muquirana.MVC.Setup
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            //Mediator
            // services.AddScoped<IMediatorHandler, MediatorHandler>();

            // //Notifications
            // services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();

            // //Event Sourcing
            // services.AddSingleton<IEventStoreService, EventStoreService>();
            // services.AddSingleton<IEventSourcingRepository, EventSourcingRepository>();

            //Cadastros
            // services.AddScoped<IProdutoRepository, ProdutoRepository>();
            // services.AddScoped<IProdutoAppService, ProdutoAppService>();
            // services.AddScoped<IEstoqueService, EstoqueService>();
             services.AddScoped<CadastrosContext>();

            // services.AddScoped<INotificationHandler<ProdutoAbaixoEstoqueEvent>, ProdutoEventHandler>();

            // //Vendas
            // services.AddScoped<IRequestHandler<AdicionarItemPedidoCommand, bool>, PedidoCommandHandler>();
            // services.AddScoped<IRequestHandler<AtualizarItemPedidoCommand, bool>, PedidoCommandHandler>();
            // services.AddScoped<IRequestHandler<RemoverItemPedidoCommand, bool>, PedidoCommandHandler>();
            // services.AddScoped<IRequestHandler<AplicarVoucherPedidoCommand, bool>, PedidoCommandHandler>();
            // services.AddScoped<IRequestHandler<IniciarPedidoCommand, bool>, PedidoCommandHandler>();
            // services.AddScoped<IRequestHandler<FinalizarPedidoCommand, bool>, PedidoCommandHandler>();
            // services.AddScoped<IRequestHandler<CancelarProcessamentoPedidoCommand, bool>, PedidoCommandHandler>();
            // services.AddScoped<IRequestHandler<CancelarProcessamentoPedidoEstornarEstoqueCommand, bool>, PedidoCommandHandler>();
            
            
            // services.AddScoped<INotificationHandler<PedidoRascunhoIniciadoEvent>, PedidoEventHandler>();
            // services.AddScoped<INotificationHandler<PedidoEstoqueRejeitadoEvent>, PedidoEventHandler>();
            // services.AddScoped<INotificationHandler<PagamentoRealizadoEvent>, PedidoEventHandler>();
            // services.AddScoped<INotificationHandler<PagamentoRecusadoEvent>, PedidoEventHandler>();
            // services.AddScoped<INotificationHandler<PedidoAtualizadoEvent>, PedidoEventHandler>();
            // services.AddScoped<INotificationHandler<PedidoItemAdicionadoEvent>, PedidoEventHandler>();

            // services.AddScoped<IPedidoRepository, PedidoRepository>();
            // services.AddScoped<IPedidoQueries, PedidoQueries>();
            // services.AddScoped<VendasContext>();

            // //Pagamentos
            // services.AddScoped<IPagamentoRepository, PagamentoRepository>();
            // services.AddScoped<IPagamentoService, PagamentoService>();
            // services.AddScoped<IPagamentoCartaoCreditoFacade, PagamentoCartaoCreditoFacade>();
            // services.AddScoped<IPayPalGateway, PayPalGateway>();
            // services.AddScoped<IConfigurationManager, ConfigurationManager>();
            // services.AddScoped<PagamentoContext>();

            // services.AddScoped<INotificationHandler<PedidoEstoqueConfirmadoEvent>, PagamentoEventHandler>();

            
        }
    }
}