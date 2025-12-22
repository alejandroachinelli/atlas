# JWT Clásico (Access + Refresh) — Diseño y Seguridad

## Objetivo

Autenticación stateless para APIs, con renovación segura usando refresh tokens.

## Diseño elegido (resumen)

- Access Token JWT: corto (minutos)
- Refresh Token: largo (días/semanas), **rotación** y **revocación**
- Refresh token **NO se guarda en texto plano**
- Se registra metadata (IP, UserAgent, fecha, revocado, reemplazado por, etc.)

## Riesgos principales y mitigaciones

- Token theft (XSS / malware) → preferir cookies HttpOnly para refresh
- CSRF (si usamos cookies) → SameSite + antiforgery según caso
- Replay de refresh token → rotación one-time-use + family tracking
