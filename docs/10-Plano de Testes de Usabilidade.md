# Plano de Testes de Usabilidade 

## Definição do(s) objetivo(s)

• Verificar se os usuários conseguem realizar operações de cadastro e gestão de perfil sem dificuldades.

•	Avaliar a eficiência da interface para consulta e movimentação de estoque.

•	Identificar possíveis barreiras na navegação e interação com o sistema de geração de relatórios.

•	Testar a clareza dos alertas automáticos e notificações do sistema.

•	Avaliar a facilidade de uso nas funcionalidades de gestão de clientes e vendas.

•	Verificar se as restrições de permissão são compreensíveis para os usuários.


## Seleção dos participantes


**Critérios para selecionar participantes:**

•	Gestores de estoque e vendas com experiência prévia em sistemas similares.

•	Funcionários do setor administrativo responsáveis pela geração de relatórios.

•	Vendedores que realizam atendimento direto a clientes.

•	Novos colaboradores sem experiência prévia com o sistema.

•	Pessoas com diferentes níveis de familiaridade com tecnologia.



**Quantidade recomendada:**

•	3 gestores/administradores

•	3 vendedores

•	2 estoquistas

•	2 novos colaboradores sem experiência prévia



## Definição de cenários de teste

**Cenário 1: Cadastro e Gestão de Perfil**

**Objetivo:** Avaliar a facilidade e intuitividade do processo de cadastro de usuário e gestão de perfil.

**Contexto:** Um novo funcionário precisa acessar o sistema pela primeira vez, criar seu perfil de usuário e posteriormente atualizar algumas informações pessoais.


**Tarefa(s):**

•	Acessar a tela inicial do sistema.

•	Localizar e clicar na opção "Cadastrar novo usuário".

•	Preencher todos os campos obrigatórios do formulário de cadastro.

•	Finalizar o cadastro e fazer login no sistema.

•	Acessar as configurações de perfil e atualizar o número de telefone.

•	Salvar as alterações e verificar se foram aplicadas com sucesso.



**Critério(s) de Sucesso(s):**

•	O usuário consegue localizar a opção de cadastro sem dificuldades.

•	Todos os campos são preenchidos corretamente e o cadastro é concluído sem erros.

•	O login é realizado com sucesso após o cadastro.

•	As informações do perfil são atualizadas corretamente.

•	Todo o processo ocorre em menos de 5 minutos, sem necessidade de assistência.


**Cenário 2: Consulta e Movimentação de Estoque**

**Objetivo:** Avaliar a eficiência na consulta de itens em estoque e no registro de entradas e saídas de produtos.

**Contexto:** Um estoquista precisa verificar a quantidade disponível de um produto específico, registrar a entrada de novas unidades e em seguida uma saída para atender a uma requisição.

**Tarefa(s):**

•	Fazer login no sistema com credenciais de estoquista.

•	Acessar o módulo de estoque.

•	Utilizar a função de busca para localizar o produto "Monitor LCD 24 polegadas".

•	Verificar a quantidade atual em estoque.

•	Registrar a entrada de 15 novas unidades do produto.

•	Registrar a saída de 5 unidades para atender a uma requisição.

•	Verificar se o estoque foi atualizado corretamente.



**Critério(s) de Sucesso(s):**

•	O usuário localiza o produto específico em menos de 30 segundos.

•	As operações de entrada e saída são registradas sem erros.

•	O sistema atualiza corretamente o saldo em estoque após cada operação.

•	As informações de estoque são consistentes após as operações.

•	Todo o processo é concluído em menos de 3 minutos.


**Cenário 3: Geração e Análise de Relatórios Financeiros**

**Objetivo:** Avaliar a facilidade de uso e clareza das informações nos relatórios financeiros gerados pelo sistema.

**Contexto:** Um gerente precisa analisar o desempenho financeiro do mês anterior, verificando receitas, despesas e lucro líquido, além de identificar os produtos mais vendidos em um período específico.

**Tarefa(s):**

•	Acessar o sistema com credenciais de gerente.

•	Navegar até o módulo de relatórios financeiros.

•	Selecionar o mês anterior como período de análise.

•	Gerar um relatório financeiro completo.

•	Identificar o valor total de receitas, despesas e lucro líquido.

•	Navegar para a seção de análise de vendas.

•	Utilizar filtros para identificar os 5 produtos mais vendidos no período.

•	Exportar os resultados em formato PDF.



**Critério(s) de Sucesso(s):**

•	O usuário consegue gerar o relatório financeiro sem dificuldades.

•	As informações financeiras são exibidas de forma clara e compreensível.

•	Os filtros de análise de vendas são localizados e aplicados corretamente.

•	O relatório é exportado com sucesso.

•	Todo o processo é concluído em menos de 4 minutos.


**Cenário 4: Configuração e Visualização de Alertas**

**Objetivo:** Avaliar a eficácia dos alertas automáticos para estoque baixo e produtos próximos do vencimento.

**Contexto:** Um administrador precisa configurar níveis mínimos de estoque para produtos críticos e verificar alertas existentes sobre produtos próximos do vencimento.

**Tarefa(s):**

•	Acessar o sistema com credenciais de administrador.

•	Navegar até a configuração de alertas de estoque.

•	Definir um nível mínimo de 10 unidades para o produto "Toner Impressora XYZ".

•	Salvar a configuração.

•	Simular uma redução no estoque para 8 unidades (abaixo do mínimo).

•	Verificar se o alerta foi gerado corretamente.

•	Navegar até o painel de alertas.

•	Filtrar por "Produtos próximos do vencimento".

•	Visualizar os detalhes de um alerta específico.

•	Marcar o alerta como "visualizado".



**Critério(s) de Sucesso(s):**

•	O nível mínimo de estoque é configurado sem dificuldades.

•	O sistema gera o alerta corretamente quando o estoque fica abaixo do mínimo.

•	Os alertas são facilmente localizados e filtrados no painel.

•	As informações dos alertas são claras e acionáveis.

•	Todo o processo é realizado em menos de 5 minutos.


**Cenário 5: Cadastro de Cliente e Registro de Venda**

**Objetivo:** Avaliar a integração entre o cadastro de clientes e o registro de vendas com atualização automática do estoque.

**Contexto:** Um vendedor precisa cadastrar um novo cliente e registrar uma venda para este cliente, verificando se o estoque é atualizado automaticamente.

**Tarefa(s):**

•	Acessar o sistema com credenciais de vendedor.

•	Navegar até o módulo de cadastro de clientes.

•	Criar um novo cadastro com nome, telefone, email e endereço.

•	Salvar o cadastro do cliente.

•	Iniciar um novo registro de venda para este cliente.

•	Adicionar 3 produtos diferentes ao carrinho de compras.

•	Escolher a forma de pagamento como "Cartão de Crédito".

•	Finalizar a venda.

•	Verificar se o estoque dos produtos vendidos foi atualizado automaticamente.

•	Consultar o histórico de compras do cliente recém-cadastrado.



**Critério(s) de Sucesso(s):**

•	O cadastro do cliente é realizado sem erros.

•	Os produtos são adicionados ao carrinho corretamente.

•	A venda é finalizada com sucesso.

•	O estoque é atualizado automaticamente após a conclusão da venda.

•	O histórico de compras do cliente é atualizado com a nova venda.

•	Todo o processo é concluído em menos de 6 minutos.



## Métodos de coleta de dados

**Métricas quantitativas:**

•	Tempo gasto para completar cada tarefa (em segundos).

•	Número de cliques necessários para concluir cada operação.

•	Taxa de conclusão das tarefas (percentual de tarefas concluídas com sucesso).

•	Número de erros cometidos durante a execução.

•	Número de vezes que o usuário solicitou ajuda.

**Métricas qualitativas:**

•	Expressões faciais e reações durante a execução das tarefas

•	Comentários espontâneos durante o teste

•	Dificuldades observadas em pontos específicos da interface

•	Confusões ou hesitações ao interagir com elementos da interface

•	Estratégias utilizadas para resolver problemas encontrados

**Questionário pós-teste:**
1.	A interface do sistema foi fácil de entender? (1-5)
   
2.	Você encontrou dificuldades para localizar as funcionalidades necessárias? (1-5)
   
3.	Os alertas e mensagens do sistema foram claros e úteis? (1-5)
   
4.	O sistema respondeu rapidamente às suas ações? (1-5)
   
5.	As informações apresentadas nos relatórios foram claras e bem organizadas? (1-5)
    
6.	Você conseguiu recuperar-se facilmente após cometer erros? (1-5)
    
7.	O que você considera mais positivo na interface do sistema?
    
8.	O que você considera mais confuso ou difícil na interface do sistema?
    
9.	Quais sugestões você daria para melhorar a experiência de uso?
    
10.	Você se sentiu confiante ao utilizar o sistema? (1-5)

    
Observação: Todos os dados coletados serão tratados conforme a LGPD (Lei Geral de Proteção de Dados), sem identificação dos participantes. Serão utilizados apenas códigos para referência aos usuários (U1, U2, etc.).


**Estava no arquivo do git**
Os dados coletados devem ajudar a entender a experiência dos usuários e os dados podem ser coletados por observação direta incluindo métricas quantitativas (quantidade de cliques, número de erros, tempo gasto para cada tarefa etc.), métricas qualitativas (dificuldades, comentários etc.) e questionários pós-teste (A interface foi fácil de entender? Você encontrou dificuldades em alguma etapa? O que poderia ser melhorado?)

Para cada voluntário do teste, é fundamental coletar e apresentar todos os dados/métricas previamente definidos, mas não se esqueça: atendendo à LGPD (Lei Geral de Proteção de Dados), nenhum dado sensível, que permita identificar o voluntário, deverá ser apresentado).
