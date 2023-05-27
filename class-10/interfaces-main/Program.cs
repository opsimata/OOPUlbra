using interfaces_main;

// Exemplo de uso
var loja = new Loja();
var roupa = new Roupa();
var calcado = new Calcado();

loja.AdicionarItem(roupa);
loja.AdicionarItem(calcado);
loja.VenderItem(0);