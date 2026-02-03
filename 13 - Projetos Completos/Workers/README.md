# Workers - Projetos Completos (Utiles no dia a dia)

## O que e um worker?
Um worker e um programa que roda sozinho para executar tarefas automaticamente.

## Importante (etica e seguranca)
- Automatizar tarefas pessoais e legitimas e ok.
- **Nao automatize processos que violem regras ou politicas da empresa.**
- Exemplo: bater ponto automaticamente nao e permitido. Use lembretes, nao automacao.

## Estrutura desta pasta
- agenda_diaria
- lembrete_ponto (somente lembrete, sem automacao de envio)
- backup_documentos
- limpeza_temp
- abrir_apps

## Como rodar
```bash
python caminho_do_script.py
```

## Como agendar no Windows (Task Scheduler)
1. Abra "Agendador de Tarefas".
2. Criar tarefa basica.
3. Defina horario (diario).
4. Aponte para `python.exe`.
5. Em argumentos, passe o caminho do script.

Exemplo:
- Programa: `C:\Python311\python.exe`
- Argumentos: `C:\...\agenda_diaria.py`

## Desafios
1. Criar log de execucao.
2. Enviar notificacao (sem automacoes ilegais).
