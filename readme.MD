Project Message Boards

Plan:
1. Create Console Application
2. Commit initial changes
3. plan next steps
4. research storing the data 
5. research taking in inputs from the console.
5. design architecture (CQRS)
 - comand parser
 - comand handler for each of the commands
 - data persistance layer

-add commands
-implement commands



questions to answer:
- should the parser have access to the list of users and projects.

normally would consider more non-functionals
document assumptions made
-> no spaces in commands
-> username has no spaces
-> project names don't include "-> @"

edge cases to handle:
- follows in the message

improvements to make:
-> use the data storage in the parsing.