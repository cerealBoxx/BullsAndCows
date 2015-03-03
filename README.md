 BullsAndCows
===============
##Web Services and Cloud – Practical Exam – September 2014

Task description
Bulls and Cows game description
Implement the server logic of the Bulls and Cows game. The rules of the game are:
1.	Both players think up a 4 digits, consisting of the digits 0-9, with no repeating digits
2.	We will name one of the players "red player" and the other one "blue player"
3.	The game is played in turns, a player is randomly selected to have the first turn
4.	The player who is in turn to play tries to guess the opponent's number:
•	He receives information about his guess in the forms of "count of bulls" and "count of cows"
•	A "bull" is a correct digit at the correct position 
•	A "cow" is a correct digit at the wrong position
•	E.g. if the opponent's number is 1234 and the current player guesses "4631", then he has 1 bull (3) and 2 cows (1 and 4)
5.	It becomes the other player's turn.
6.	Steps 4 and 5 are repeated until someone guesses the opponents number (i.e. has 4 "bulls")
The game always ends with one player winning
Game logic
The game logic is performed as follows:
1.	A user registers an account, providing credentials (username and password)
2.	The user can login into their account using their credentials (username and password)
•	S/he receives an access token that is used to authenticated theirself in the system
3.	An authenticated user creates a game
•	The game is created and is marked as available for joining
•	The creator user is marked as red player
•	S/he provides a four non-repeating digits that are their number (called user-number)
4.	Another authenticated user joins the game
•	S/he provides a four non-repeating digits, that are their number (called user-number)
•	He is marked as blue player
5.	When a blue player joins a game:
•	The server randomly decides which player starts first 
•	For explanation purposes, let's assume the red  is chosen
•	The creator of the game receives a notification that their game now has a blue player
•	The player in turn receives a notification that it is their turn in the game
•	The game can be played
6.	The player in turn (in our case - the red player) can make a guess against the number of their opponent (in our case - the blue player)
•	They send four non-repeating digits (called guess-number)
•	The server compares the guess-number against their opponents user-number and returns the corresponding bulls and cows
•	If the guess-number is the same as the opponent's user-number (i.e. it has 4 bulls), the game is finished, and scores are applied
•	The winner gets a score "won"
•	The loser gets a score "lost"
•	If the guess-number is not the same as the user-number, the server marks that the other player is in turn (in our case the blue)
•	The other player receives a notification that their opponent have finished their turn
7.	Repeat step 6 while one of the players guesses right the user-number of their opponent
8.	When a player guesses the number of their opponent:
•	The winner is given a score "won" and receives a notification that s/he has won the game
•	The loser is given a score "lost" and receives a notification that s/he has lost the game
Every user can play many games simultaneously.

