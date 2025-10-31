🐉 Dados e Dragões 🎲

Um sistema em C# para gerenciar RPGs, registrar notas e calcular médias de avaliações.
Feito para aprender dicionários, listas e interação com o usuário via console de forma divertida.

⚔️ Funcionalidades

📝 Registrar RPG
Adicione novos RPGs ao sistema e comece sua aventura!

📜 Listar RPGs
Veja todos os RPGs cadastrados e suas notas de aventura.

⭐ Avaliar RPG
Registre suas notas de cada RPG para manter um ranking do seu grupo.

🧮 Mostrar média de notas
Calcule e veja a média de cada RPG, de forma segura e clara.

🔄 Menu interativo
Navegue entre opções de forma simples e prática.

🛠️ Pré-requisitos

.NET SDK 7.0+

Um editor de código ou IDE compatível com C#
(Visual Studio, VS Code, JetBrains Rider, etc.)

🎯 Como jogar

Clone ou baixe o projeto:

git clone https://github.com/augustosalmoao/DadosEDragoes.git


Abra o terminal no diretório do projeto e execute:

dotnet run


Escolha a opção desejada no menu:

1 → Registrar RPG
2 → Mostrar todos os RPGs
3 → Avaliar um RPG
4 → Exibir a média de um RPG
-1 → Sair


Siga as instruções do console e divirta-se!

📂 Estrutura do código

Dictionary<string, List<int>> registroDeRPGs → Armazena os RPGs e suas notas.

Funções principais:

ExibirMensagemDeBoasVindas() → Mostra mensagem de abertura.

ExibirOpcoesDoMenu() → Menu interativo principal.

RegistrarRPG() → Adiciona RPGs ao registro.

ListarRPG() → Lista RPGs e suas notas.

AvaliarRPG() → Adiciona notas de avaliação.

MostrarMediaRPG() → Calcula e mostra a média de notas.

⚠️ Observações

Verifica se o RPG existe antes de avaliar ou mostrar a média.

Evita calcular média de listas vazias.

Fácil de expandir para salvar dados em arquivos ou banco de dados.

🎨 Estilo

Console colorido e estilizado (mensagens, menus e títulos).

Tema inspirado em RPGs clássicos: D&D, Tormenta20, Ordem Paranormal.

Fácil de personalizar para seu próprio grupo de RPG.

🏷️ Licença

Projeto open source, criado para aprendizado e diversão.
Sinta-se livre para usar, modificar e compartilhar!
