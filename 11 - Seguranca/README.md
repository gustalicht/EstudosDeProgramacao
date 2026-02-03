# Seguranca - Guia Profundo (Sem Resumo)

## 1) Mentalidade
Seguranca e parte do design. O atacante sempre tenta o caminho mais facil.

------------------------------------------------------------

## 2) Autenticacao vs Autorizacao
- Autenticacao: quem voce e.
- Autorizacao: o que voce pode fazer.

------------------------------------------------------------

## 3) Armazenamento de senha (correto)
- Nunca salvar senha em texto.
- Use hash forte + salt (bcrypt, argon2).

------------------------------------------------------------

## 4) JWT (passo a passo)
1. Usuario faz login.
2. Servidor cria token (header + payload + assinatura).
3. Cliente envia token em cada request.
4. Servidor valida assinatura.

------------------------------------------------------------

## 5) OWASP Top 10 (na pratica)
- Injection: sempre validar entrada.
- XSS: escapar saida.
- CSRF: tokens em formularios.
- Misconfiguration: revisar headers e configs.

------------------------------------------------------------

## 6) CORS
Define quem pode acessar sua API.
Se mal configurado, qualquer site pode chamar sua API.

------------------------------------------------------------

## 7) TLS/HTTPS (por baixo dos panos)
- Handshake cria chave segura.
- Dados passam criptografados.

------------------------------------------------------------

## 8) Rate limiting
Evita abuso e ataques de forca bruta.

------------------------------------------------------------

## 9) Segredos
- Nunca subir senhas no repo.
- Use env vars ou secret manager.

------------------------------------------------------------

## Exercicios
1. Proteger endpoint com JWT.
2. Criar role admin.
3. Simular SQL injection e bloquear.
