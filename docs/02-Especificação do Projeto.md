# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

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

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve permitir que os usuários realizem cadastro do seu perfil. | ALTA | 
|RF-002| A aplicação deve permitir que o usuário inclua comentários ao fazer uma avaliação de uma agência de intercâmbio    | ALTA |
|RF-003|  O sistema deverá permitir que o usuário realize a entrada e saída de produtos. | ALTA |
|RF-004|  O sistema deverá permitir o cadastro de produtos com nome, descrição, preço de entrada e saída. | ALTA |
|RF-005|  O sistema deverá gerar relatórios financeiros mensais, apresentando receitas, despesas e lucro líquido. | ALTA |
|RF-006|  O sistema deverá permitir o cadastro e a gestão de clientes, incluindo nome, contato e histórico de compras. | ALTA |
|RF-007| O sistema deve permitir a transferência de estoque interna | BAIXA |
|RF-008|  | ALTA |
|RF-009|  | ALTA |
|RF-010|  | ALTA |



### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve apresentar uma interface intuitiva que permita ao usuário verificar informações de seu estoque e controle de caixa de forma clara. | ALTA | 
|RNF-002| O sistema deve ter design responsivo para que se adapte a diferentes tamanhos de telas. |  ALTA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)

