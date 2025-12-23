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

## Hashing

- Password: hash lento (PBKDF2 vía PasswordHasher de ASP.NET Core Identity)
- Refresh Token: hash SHA-256 + pepper (token aleatorio fuerte)
Rationale:
- Passwords requieren protección contra diccionario humano y brute-force masivo.
- Refresh tokens ya son aleatorios, el riesgo principal es filtración/replay, mitigado con rotación + revocación + hash + pepper.