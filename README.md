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