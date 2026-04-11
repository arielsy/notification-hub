# notification-hub
Uma plataforma que recebe pedidos de notificação via API e despacha por múltiplos canais (email, SMS, push, webhook, whatsApp)

## Visão do Projeto
Notification Hub é um sistema centralizado de notificações inspirado em plataformas como Novu, Courier e Knock. O objetivo é receber uma requisição genérica e rotear para o canal correto.

## Roadmap
| Fase | Descrição                                         | Status         |
|------|---------------------------------------------------|----------------|
| A0   | Console App + Models + Git (Conventional Commits) | ✅ Concluída    |
| A1   | Docker + SQL Server                               | 🔄 Em Andamento |
| A2   | Clean Architecture + API REST                     | ⬜              |
| A3   | Redis (cache, rate limiting)                      | ⬜              |
| A4   | RabbitMQ (filas por canal)                        | ⬜              |
| A5   | Testes (unit, integração, carga)                  | ⬜              |
| A6   | CI/CD + Observabilidade                           | ⬜              |

## Como Rodar

**Pré-requisito:** Docker Desktop instalado e em execução.

```bash
docker-compose up --build
```

Isso vai:
1. Subir SQL Server 2022 em container com volume persistente
2. Aguardar o banco estar pronto (healthcheck automático)
3. Compilar e executar a aplicação .NET
4. Salvar uma notificação no banco e imprimir o resultado

```bash
# Para os containers preservando os dados
docker-compose down

# Para os containers e apaga os dados
docker-compose down -v
```

Conexão direta ao banco (Azure Data Studio / SSMS): `localhost:1433`, usuário `sa`, senha `Hub@Sql2026!`.