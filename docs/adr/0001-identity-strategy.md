# ADR 0001 — Estrategia de Identidad (JWT vs OIDC vs BFF)

## Contexto

Atlas necesita autenticación para un frontend tipo SPA (React) y APIs .NET.

## Opciones evaluadas

1) JWT clásico (access token + refresh token) implementado en el backend
2) OIDC/OAuth2 con un Identity Provider (IdP)
3) BFF (Backend for Frontend) con cookies seguras y tokens ocultos al frontend

## Decisión

Implementar las 3 estrategias como módulos comparables dentro del proyecto Atlas, para:

- comprender trade-offs reales
- demostrar experiencia de mercado (JWT clásico)
- demostrar estándar moderno (OIDC)
- demostrar enfoque de máxima seguridad para SPA (BFF)

## Consecuencias

Pros:

- Portfolio demostrable con comparaciones reales

Contras:

- Mayor complejidad inicial (mitigado por implementación incremental)
