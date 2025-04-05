# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| **CT01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve permitir que os usuários realizem cadastro do seu perfil. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar corretamente no sistema. |
| Passos 	| 01. Acessar a página de cadastro. 02. Preencher os campos obrigatórios (nome, email, senha e confirmação de senha). 03. Clicar no botão "Cadastrar". 04. Verificar se o sistema exibe uma mensagem de sucesso. 05. Tentar fazer login com as credenciais recém-criadas. |
|Critério de Êxito | O sistema exibe uma mensagem de sucesso após o cadastro. O usuário consegue fazer login com as credenciais cadastradas. |
|  	|  	|
| Caso de Teste 	| **CT02 – Consulta de Itens no Estoque**	|
|Requisito Associado | RF-002 - O sistema deverá permitir a consulta de itens cadastrados no estoque, exibindo a quantidade disponível dos mesmos. |
| Objetivo do Teste 	| Garantir que os usuários possam visualizar os produtos cadastrados e suas respectivas quantidades. |
| Passos 	| 01. Acessar a seção de estoque do sistema. 02. Pesquisar um produto pelo nome ou código. 03. Verificar se as informações de quantidade disponível e detalhes do produto são exibidas corretamente. |
|Critério de Êxito | O sistema exibe corretamente os produtos cadastrados e suas respectivas quantidades disponíveis. |
|  	|  	|
| Caso de Teste 	| **CT03 – Entrada e Saída de Produtos no Estoque**	|
|Requisito Associado | RF-003 - O sistema deverá permitir que o usuário realize a entrada e saída de produtos. |
| Objetivo do Teste 	| Validar se o sistema permite registrar corretamente a movimentação do estoque. |
| Passos 	| 01. Acessar a seção de gerenciamento de estoque. 02. Selecionar um produto cadastrado. 03. Inserir uma quantidade para entrada no estoque e confirmar. 04. Inserir uma quantidade para saída no estoque e confirmar. 05. Verificar se a quantidade total é atualizada corretamente. |
|Critério de Êxito | O sistema atualiza corretamente a quantidade de estoque após cada operação. |
|  	|  	|
| Caso de Teste 	| **CT04 – Cadastro de Produtos**	|
|Requisito Associado | RF-004 - O sistema deverá permitir o cadastro de produtos com nome, descrição, preço de entrada e saída. |
| Objetivo do Teste 	| Garantir que os usuários possam cadastrar novos produtos corretamente. |
| Passos 	| 01. Acessar a seção de cadastro de produtos. 02. Preencher os campos obrigatórios (nome, descrição, preço de entrada, preço de saída). 03. Clicar no botão "Cadastrar Produto". 04. Verificar se o produto foi salvo corretamente e aparece na listagem do estoque. |
|Critério de Êxito | O produto é cadastrado com sucesso e aparece na lista de produtos disponíveis. |
|  	|  	|
| Caso de Teste 	| **CT05 – Geração de Relatório Financeiro Mensal**	|
|Requisito Associado | RF-005 - O sistema deverá gerar relatórios financeiros mensais, apresentando receitas, despesas e lucro líquido. |
| Objetivo do Teste 	| Verificar se o sistema gera corretamente os relatórios financeiros com receitas, despesas e lucro líquido. |
| Passos 	| 01. Acessar a seção de relatórios financeiros. 02. Selecionar um mês específico para gerar o relatório. 03. Clicar no botão "Gerar Relatório". 04. Verificar se os dados de receitas, despesas e lucro líquido são exibidos corretamente. 05. Testar a exportação do relatório em formatos PDF e CSV. |
|Critério de Êxito | O relatório financeiro é gerado corretamente com os valores esperados. O usuário pode visualizar e exportar o relatório. |
| Caso de Teste 	| **CT06 – Cadastro e Gestão de Clientes**	|
|Requisito Associado | RF-006 - O sistema deverá permitir o cadastro e a gestão de clientes, incluindo nome, contato e histórico de compras. |
| Objetivo do Teste 	| Verificar se o sistema permite cadastrar e gerenciar informações de clientes, incluindo histórico de compras. |
| Passos 	|1.	Acessar o sistema com credenciais válidas. 2.	Navegar até a seção de cadastro de clientes. 3.	Cadastrar um novo cliente. 4.	Salvar o cadastro e verificar se foi registrado corretamente. 5.	Editar informações do cliente cadastrado. 6.	Verificar o histórico de compra. 7.	Buscar clientes por diferentes critérios. |
|Critério de Êxito | O sistema permite cadastrar e gerenciar informações de clientes corretamente, mantendo histórico atualizado de compras e permitindo consultas por diferentes critérios.|
| Caso de Teste 	| **CT07 – Alertas para Estoque Mínimo**	|
|Requisito Associado | RF-007 - O sistema deverá gerar alertas automáticos para produtos com estoque abaixo do nível mínimo definido. |
| Objetivo do Teste 	|Verificar se o sistema identifica e alerta sobre produtos com estoque abaixo do nível mínimo. |
| Passos 	|1.	Acessar o sistema com credenciais válidas. 2.	Cadastrar ou editar um produto definindo um nível mínimo de estoque. 3.	Registrar saídas do produto até que o estoque fique abaixo do nível mínimo definido. 4.	Verificar se o sistema exibe alerta visual na interface, adiciona o produto à lista de produtos com estoque baixo e envia notificação (se aplicável). 5.	Verificar se existe uma seção consolidada para visualizar todos os produtos com estoque baixo. |
|Critério de Êxito |O sistema identifica corretamente produtos com estoque abaixo do nível mínimo e gera alertas adequados para informar os usuários. |
| Caso de Teste 	| **CT08 – Transferência de Estoque Interna**	|
|Requisito Associado |RF-008 - O sistema deve permitir a transferência de estoque interna. |
| Objetivo do Teste 	| Verificar se o sistema permite realizar transferências de produtos entre diferentes locais ou departamentos internos. |
| Passos 	|1.	Acessar o sistema com credenciais válidas. 2.	Navegar até a seção de transferência de estoque. 3.	Selecionar a origem (local/departamento atual do produto). 4.	Selecionar o destino da transferência. 5.	Adicionar os produtos a serem transferidos com suas quantidades. 6.	Confirmar a transferência. 7.	Verificar se o estoque foi atualizado corretamente em ambos os locais. 8.	Verificar o registro da transferência no histórico de movimentações. |
|Critério de Êxito | O sistema permite realizar transferências internas de estoque, atualizando corretamente as quantidades nos locais de origem e destino, e mantendo registro da operação. |
| Caso de Teste 	| **CT09 – Histórico Individual de Produto**	|
|Requisito Associado |RF-009 - O sistema deve permitir ver o histórico individual de cada produto. |
| Objetivo do Teste 	| Verificar se o sistema exibe o histórico completo de movimentações de um produto específico. |
| Passos 	|1.	Acessar o sistema com credenciais válidas. 2.	Navegar até a seção de produtos ou estoque. 3.	Buscar e selecionar um produto específico. 4.	Acessar a opção de visualizar histórico do produto. 5.	Verificar se o sistema exibe todas as movimentações do produto: entradas, saídas, ajustes de estoque, datas das movimentações e responsáveis pelas operações. 6.	Verificar a possibilidade de filtrar o histórico por período. |
|Critério de Êxito | O sistema exibe corretamente todo o histórico de movimentações do produto selecionado, com informações detalhadas sobre cada operação. |
| Caso de Teste 	| **CT010 – - Notificação de Prazo Final de Pagamento**	|
|Requisito Associado |RF- 010 - O sistema deve notificar quando o cliente estiver no prazo final de pagamento. |
| Objetivo do Teste 	| Verificar se o sistema identifica clientes com prazo de pagamento próximo do vencimento e emite notificações apropriadas. |
| Passos 	|1.	Acessar o sistema com credenciais válidas. 2.	Cadastrar vendas com pagamento a prazo para clientes. 3.	Ajustar a data do sistema para aproximar-se da data limite de pagamento. 4.	Verificar se o sistema: exibe alerta visual na interface, lista os pagamentos pendentes próximos do vencimento, envia notificação ao usuário responsável (se aplicável) e envia lembretes ao cliente (se aplicável). 5.	Verificar a existência de uma seção consolidada para visualizar todos os pagamentos pendentes. |
|Critério de Êxito | O sistema identifica corretamente clientes com pagamentos próximos do vencimento e emite as notificações adequadas para os usuários do sistema. |
| Caso de Teste 	| **CT011 – Visualizar Produtos com mais Vendas em Períodos Específicos**	|
|Requisito Associado |RF-011 - O sistema deve permitir visualizar quais produtos geram mais vendas em períodos específicos do ano. |
| Objetivo do Teste 	| Verificar se o sistema exibe corretamente relatórios de produtos mais vendidos por período específico. |
| Passos 	|1.	Acessar o sistema com credenciais válidas. 2.	Navegar até a seção de relatórios/análises de vendas. 3.	Selecionar a opção para visualizar produtos mais vendidos. 4.	Definir um período específico (mês, trimestre, estação do ano). 5.	Verificar se o sistema gera o relatório com os dados solicitados. 6.	Validar se os dados apresentados correspondem às vendas registradas no período selecionado. |
|Critério de Êxito | O sistema exibe corretamente o relatório dos produtos mais vendidos no período selecionado, apresentando os dados de forma organizada e com cálculos precisos. |
| Caso de Teste 	| **CT012 – Controle de Agendamentos e Atendimentos**	|
|Requisito Associado |RF-012 - O sistema deve permitir o controle de agendamentos e atendimentos aos clientes. |
| Objetivo do Teste 	| Verificar se o sistema permite criar, visualizar, editar e excluir agendamentos, além de registrar atendimentos realizados. |
| Passos 	|1.	Acessar o sistema com credenciais válidas. 2.	Navegar até a seção de agendamentos. 3.	Criar um novo agendamento com dados de cliente, data, hora e serviço. 4.	Verificar se o sistema registra corretamente o agendamento. 5.	Editar informações do agendamento e verificar se as alterações são salvas. 6.	Registrar a conclusão de um atendimento. 7.	Verificar se o histórico de atendimentos é atualizado. 8.	Cancelar um agendamento e verificar se o sistema processa corretamente. |
|Critério de Êxito | O sistema permite gerenciar agendamentos (criar, editar, cancelar) e registrar atendimentos, mantendo o histórico atualizado e exibindo corretamente os status de cada item. |
| Caso de Teste 	| **CT013 – Pesquisa Avançada no Histórico de Vendas**	|
|Requisito Associado | RF-013 - O sistema deve permitir a pesquisa avançada no histórico de venda de produtos. |
| Objetivo do Teste 	| Verificar se o sistema possibilita realizar buscas detalhadas no histórico de vendas usando diferentes critérios de filtro. |
| Passos 	|1.	Acessar o sistema com credenciais válidas. 2.	Navegar até a seção de histórico de vendas. 3.	Testar pesquisa por diferentes critérios. 4.	Combinar múltiplos critérios em uma única pesquisa. 5.	Verificar se os resultados correspondem aos critérios utilizados. |
|Critério de Êxito |O sistema retorna resultados precisos e completos para cada critério de pesquisa utilizado, incluindo combinações de múltiplos filtros. |
| Caso de Teste 	| **CT014 – Registro de Vendas em Tempo Real com Atualização do Estoque**	|
|Requisito Associado |RF-014 - O sistema deve permitir o registro de vendas em tempo real com atualização automática do estoque. |
| Objetivo do Teste 	| Verificar se o sistema registra corretamente as vendas e atualiza automaticamente o estoque após cada venda. |
| Passos 	|1.	Acessar o sistema com credenciais válidas. 2.	Verificar o nível de estoque de um produto específico antes da venda. 3.	Navegar até a seção de registro de vendas. 4.	Registrar uma nova venda incluindo o produto verificado. 5.	Finalizar a venda. 6.	Verificar se o sistema registrou corretamente a venda. 7.	Verificar se o estoque do produto foi atualizado automaticamente. 8.	Verificar se o histórico de vendas foi atualizado. |
|Critério de Êxito | O sistema registra a venda corretamente e atualiza o estoque automaticamente, refletindo a quantidade vendida. |
| Caso de Teste 	| **CT015 – Alerta de Produtos Próximos do Vencimento**	|
|Requisito Associado |RF-015 - O sistema deve identificar e alertar sobre produtos próximos do vencimento. |
| Objetivo do Teste 	| Verificar se o sistema identifica corretamente produtos próximos da data de vencimento e emite alertas apropriados. |
| Passos 	|1.	Acessar o sistema com credenciais válidas. 2.	Cadastrar ou modificar produtos com datas de vencimento próximas. 3.	Verificar se o sistema exibe alertas visuais na interface para produtos com vencimento próximo. 4.	Verificar se existe uma seção específica para listar produtos próximos do vencimento. 5.	Testar se o sistema envia notificações (e-mail, sistema) sobre produtos prestes a vencer. |
|Critério de Êxito | O sistema identifica corretamente produtos próximos do vencimento, exibe alertas visuais e/ou envia notificações conforme configurado. |
| Caso de Teste 	| **CT016 – Controle de Acesso para Alterações no Estoque**	|
|Requisito Associado |RF-016 - Apenas usuários ADM podem alterar ou excluir registros do estoque. |
| Objetivo do Teste 	| Verificar se o sistema restringe corretamente as operações de alteração e exclusão de registros de estoque apenas para usuários com perfil de administrador. |
| Passos 	|1.	Acessar o sistema com credenciais de usuário comum (não administrador). 2.	Navegar até a seção de gerenciamento de estoque. 3.	Tentar alterar informações de um produto no estoque. 4.	Tentar excluir um registro de produto do estoque. 5.	Sair do sistema. 6.	Acessar o sistema com credenciais de usuário administrador (ADM). 7.	Tentar realizar as mesmas operações de alteração e exclusão no estoque. |
|Critério de Êxito | O sistema permite que apenas usuários com perfil ADM realizem alterações e exclusões no estoque, enquanto exibe mensagem de acesso negado ou oculta estas funcionalidades para usuários comuns. |
