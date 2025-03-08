/# Especificações do Projeto

Nestas especificações, visamos ao máximo entender cada persona, com o principal objetivo de criar um sistema, respeitando suas limitações e seja capaz 
de sanar todas as necessidades voltadas a gestão e controle de vendas/estoque das mesmas.

## Personas

Identifique, em torno de, 5 personas. Para cada persona, lembre-se de descrever suas angústicas, frustrações e expectativas de vida relacionadas ao problema. Além disso, defina uma "aparência" para a persona. Para isso, você poderá utilizar sites como [https://this-person-does-not-exist.com/pt#google_vignette](https://this-person-does-not-exist.com/pt) ou https://thispersondoesnotexist.com/ 


<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2025-1-e2-proj-int-t3-autonomize/blob/c68b1d6eff6adff121fbcfbab58807eda6cbe09b/docs/personas/GeovanaPaula-Persona.jpg" alt="Persona1"/>

<h3><p align="center"><b>Persona 01</b></p></h2></br>

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2025-1-e2-proj-int-t3-autonomize/blob/c68b1d6eff6adff121fbcfbab58807eda6cbe09b/docs/personas/LucasAndrade-Persona.jpg" alt="Persona2"/>

<h3><p align="center"><b>Persona 02</b></p></h2></br>

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2025-1-e2-proj-int-t3-autonomize/blob/586fd086e60cf6f999c70f869c83a44608054b67/docs/personas/TaniaFigueiredo-Persona.jpg" alt="Persona3">

<h3><p align="center"><b>Persona 03</b></p></h2></br>

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2025-1-e2-proj-int-t3-autonomize/blob/d44a05de6b31d3c17d0c07648abc4fa6b0e852a9/docs/personas/JoaoSilva-Persona.png" alt="Persona4">

<h3><p align="center"><b>Persona 04</b></p></h2></br>

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2025-1-e2-proj-int-t3-autonomize/blob/dc6e28062fcbfea820c5d8d615304862f7c06bd3/docs/personas/ValdireneSantos-Persona.png" alt="Persona5">

<h3><p align="center"><b>Persona 05</b></p></h2></br>

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2025-1-e2-proj-int-t3-autonomize/blob/dc6e28062fcbfea820c5d8d615304862f7c06bd3/docs/personas/GeraldoPereira-Persona.png" alt="Persona6">

<h3><p align="center"><b>Persona 06</b></p></h2></br>

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Geovana Paula  | Visualizar qual produto gera mais vendas em determinados momentos do ano. | Produzir mais desses para  manter em estoque antes desta época do ano entrar.|
|Geovana Paula       | Saber quanto de lucro obteve naquele mês de vendas.                 | Ter um controle maior de gastos dentro do orçamento para o próximo mês. |
|Lucas Andrade       | Acompanhar minhas entradas e saídas financeiras com clareza.                 | Saber exatamente quanto estou lucrando a cada mês. |
|Lucas Andrade       | Controlar meus atendimentos e agendamentos de forma prática e rápida.                 | Garantir que não perca nenhum compromisso com meus clientes. |
|Tania Figueiredo       | Controlar meu estoque de produtos e valores de revenda.                 | Garantir que nao estou tendo prejuizo e melhor atender meus clientes. |
|Geraldo Pereira| Ter controle da movimentação de catálogo, verificando entradas e saídas de estoque.|Analisar vendas e planejar compras, não vender itens que não houver em estoque. |
| Geraldo Pereira | Rastrear peças e itens essenciais para manutenção de relógios. | Localizar rapidamente o que precisa durante os reparos.| 
| Geraldo Pereira | Receber alertas quando o estoque de peças específicas estiver baixo. | Fazer pedidos com antecedência e não ficar sem material. | 
| Geraldo Pereira | Garantir que sempre tenha mercadorias para reposição | Atender todos os clientes sem atrasos.


## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve permitir que os usuários realizem cadastro do seu perfil. | ALTA | 
|RF-002|     | ALTA |
|RF-003|  O sistema deverá permitir que o usuário realize a entrada e saída de produtos. | ALTA |
|RF-004|  O sistema deverá permitir o cadastro de produtos com nome, descrição, preço de entrada e saída. | ALTA |
|RF-005|  O sistema deverá gerar relatórios financeiros mensais, apresentando receitas, despesas e lucro líquido. | ALTA |
|RF-006|  O sistema deverá permitir o cadastro e a gestão de clientes, incluindo nome, contato e histórico de compras. | ALTA |
|RF-007| O sistema deve permitir a transferência de estoque interna. | BAIXA |
|RF-008| O sistema deve permitir ver o historico individual de cada produto | ALTA |
|RF-009| O sistema deve notificar quando o cliente estiver no prazo final de pagamento  | ALTA |
|RF-010|  | ALTA |



### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve apresentar uma interface intuitiva que permita ao usuário verificar informações de seu estoque e controle de caixa de forma clara. | ALTA | 
|RNF-002| O sistema deve ter design responsivo para que se adapte a diferentes tamanhos de telas. | ALTA | 
|RNF-003| O sistema deve ter compatibilidade em navegadores como chrome, firefox e edge | ALTA | 
|RNF-004| O sistema deve ter design responsivo para que se adapte a diferentes tamanhos de telas. | ALTA |
|RNF-005| O sistema deve estar disponivel 99.9% do tempo(podendo ficar indisponível apenas 5horas por ano)| ALTA | 
|RNF-006| O tempo máximo de aprendizado para um novo usuário deve ser inferior a 1 hora. | ALTA |
|RNF-007| O sistema deve exigir autenticação por meio de login e senha fortes. | ALTA |
|RNF-008| O sistema deve responder a qualquer requisição em no máximo 10 segundos. | ALTA |

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |
|03| O sistema deve ser desenvolvido usando C# e JavaScript|
|04| O sistema deve estar em conformidade com a LGPD (Lei Geral de Proteção de Dados).        |



## Diagrama de Casos de Uso

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2025-1-e2-proj-int-t3-autonomize/blob/main/docs/img/Diagrama%20de%20caso%20de%20uso.png">

