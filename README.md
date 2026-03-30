# Caos na Cantina – IHC & UX

## 📚 Disciplina
Interação Humano Computador e UX  
Centro Universitário UNA  

## 👨‍🏫 Professor
Daniel Henrique Matos de Paiva  

## 🎯 Objetivo do Projeto
Este projeto consiste no desenvolvimento de uma **aplicação console em C# (.NET)** para simular um sistema de pedidos de uma cantina universitária.

O principal objetivo é **melhorar a experiência do usuário**, corrigindo falhas comuns de usabilidade, como:
- Fechamento inesperado do sistema
- Falta de mensagens claras de erro
- Ausência de controle do usuário sobre o fluxo do pedido

Para isso, foram aplicadas **Heurísticas de Usabilidade de Jakob Nielsen** conforme solicitado na lista de exercícios.

---

## 🧠 Heurísticas de Nielsen Aplicadas

### ✅ Heurística #1 – Visibilidade do Status do Sistema
O sistema informa constantemente em qual etapa do pedido o usuário se encontra, exibindo mensagens como:
- `[Passo 1 de 3] Seleção de Produto`
- `[Passo 2 de 3] Quantidade`
- `[Passo 3 de 3] Confirmação`

Isso garante clareza e reduz a ansiedade do usuário durante o processo.

---

### ✅ Heurística #3 – Controle e Liberdade do Usuário
O usuário pode:
- Digitar **`voltar`** para corrigir informações anteriores
- Digitar **`cancelar`** para abortar o pedido a qualquer momento

Essas opções evitam que o usuário fique “preso” em uma etapa ou precise reiniciar o programa à força.

---

### ✅ Heurística #9 – Ajuda no Reconhecimento e Recuperação de Erros
Entradas inválidas são tratadas de forma clara e educativa.  
Exemplo de mensagem:
> "Código 99 não encontrado. Nossos códigos vão de 1 a 10. Tente novamente."

Além disso, o sistema impede que letras ou valores inválidos causem falhas na aplicação.

---

## ⚙️ Tecnologias Utilizadas
- Linguagem: **C#**
- Plataforma: **.NET Console Application**
- Ambiente de desenvolvimento: **Visual Studio** (ou similar)
