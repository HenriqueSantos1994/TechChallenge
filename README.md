# Tech Challenge - FIAP - Grupo 12

## Descrição
Este repositóri contém o codigo-fonte de uma api para garenciamento para lanchonete, conforme desafio técnico proposto nas
disciplinas de Arquitetura de Software da Pós Tech - FIAP. Esta API está desenvolvida em .NET 8, e tem por objetivo gerenciar as principais operações da lanchonete,
considerando o cadastro de clientes, produtos, criação e acompanhamento de pedidos, e pagamentos, integrando-se ao Mercado Pago.

## Getting Started

### Pré-Requisitos
- Docker
- .NET SDK
- Opcionalmente, uma IDE como o Visual Studio ou VSCode


### Configuração
1. Clone o repositório:
   ```bash
   git clone https://github.com/HenriqueSantos1994/TechChallenge.git
    ```

2. Inicie o serviço utilizando Docker:

   ```bash
    docker-compose up -d
   ```

3. Acesse o swagger da aplicação para ter acesso a todos os endpoints

   > [http://localhost:5001/swagger/index.html](http://localhost:5001/swagger/index.html)


8. Para finalizar o serviço utilizando docker, execute:

   ```bash
    docker-compose down
   ```
