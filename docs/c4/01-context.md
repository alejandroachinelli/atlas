# C4 — Contexto

```mermaid
flowchart LR
    User[Usuario] --> Web[React Web App]
    Web --> API[Atlas API .NET]
    API --> SQL[(SQL Database)]
    API --> Redis[(Redis Cache)]
    API --> LLM[LLM Provider]
```

## Notas

- El sistema se diseña como backend modular en .NET
- Se contempla integracion futura con IA (RAG/agentes)

**Por qué C4:** porque te fuerza a pensar sistema, no endpoints sueltos.
