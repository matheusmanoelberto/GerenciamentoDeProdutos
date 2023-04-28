using GerenciamentoDeProdutos;

EstoqueMercado estoqueDoMercadoMP = new EstoqueMercado();
estoqueDoMercadoMP.nome_produto = "Caneta";
estoqueDoMercadoMP.fabricante = "BIC";
estoqueDoMercadoMP.codigo_barras = "0248516815";
estoqueDoMercadoMP.quatidade_estoque = 100;
estoqueDoMercadoMP.valor_compra = 1.00;
estoqueDoMercadoMP.valor_unitario = 2.00;

Console.WriteLine("Produto " + estoqueDoMercadoMP.nome_produto + " Valor " + estoqueDoMercadoMP.valor_unitario);