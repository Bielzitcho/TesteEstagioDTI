# VAGA: Estágio em Desenvolvimento de Software (Modelo Híbrido) - Gabriel Arthur de Medeiros Freitas

##Tópico 1: Premissas assumidas
No desenvolvimento do problema, utilizei a linguagem C#. Construí uma solução a partir do console que oferece ao Senhor Eduardo, a melhor escolha do PetShop a partir do menor preço e em caso de empate a com a menor distância do usuário.  

##Tópico 2: Decisões de projeto  
- A partir do pensamento de uma solução simples e eficiente, trabalhei com uma classe `PetShop`, organizando o código.
- Utilizei uma propriedade booleana "TaxaFixa" na classe `PetShop`, que indica se a taxa é fixa (ex: acrescentar R$ 5) ou não fixa (ex: adicionar 20%). Essa propriedade é aplicada apenas nos finais de semana.
- No `Program.cs`, instanciei os objetos antes do `main`, eliminando a necessidade de passá-los como parâmetro nos métodos.
- As instâncias dos PetShops foram armazenadas em um Array, permitindo a execução do método através de um loop e garantindo legibilidade e automatização.
- As condições dos `if` foram armazenadas em variáveis para facilitar a leitura e o entendimento do código.

##Tópico 3: Instruções para executar o programa  
Após abrir a solução e executá-la, o programa solicitará:
1. Uma data válida no formato "dd/MM/yyyy", igual ou posterior à data atual.
2. A quantidade de cães de porte grande que o usuário levará para tomar banho.
3. A quantidade de cães de porte pequeno que o usuário levará para tomar banho.
Após fornecer todas as entradas solicitadas, o programa executará o método e retornará a saída mais eficiente para o usuário (menor preço e, em caso de empate, menor distância do usuário).
