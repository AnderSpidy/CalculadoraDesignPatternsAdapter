# CalculadoraDesignPatternsAdapter

O Adapter é responsável por converter uma interface de classe em outra interface que é utilizada pelos clientes, fazendo com que as classes de interfaces diferentes trabalhem juntas.
<br>
Isso facilita pois faz classes independentes trabalharem juntas e suportar operações diferentes, isso também permite a conversão de interface, ou seja, substituir o comportamento.
<br>
Então utilisamos essa simples calculadora, e criamos uma calasse que simplismente teria um método em que imprime na tela do Console os histórico das operações que foram feitas em tempo de aplicação.
<br>
Então criamos uma Interface ITarget em que teria as "novas funcionalidades" da classe adaptadora de operador.
<br>
Esta classe Adapter vai implementar a interface ITarget, e como atributo tera a classe que vai ser adaptada. Dessa forma podemos utilizar seus métodos, e fazer as adaptações dentro desta classe.
<br> 
Por fim, na classe main, instanciamos a classe adapter no molde da propria interface, para que possamos utilizar seus métodos adaptados, que no caso, era simplesmente, imprimir os histórico, porem, de outra coloração. (O detalhe, é que a classe "original" não foi modificado em nada.)

<br>
Anderson Reinaldo da Silva = Código base da calculadora com as operações
<br>
Carlos Eduardo de Almeida Pasin = Implementação do Adapter 
<br>
Luan do Vale Cabral = Panejamento e Idealização
