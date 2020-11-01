https://www.hackerrank.com/challenges/tower-breakers-1/problem

For m == 1 (height of all towers) theNext player wins.
For m != 1, for a (m,m) test case, N player will win.
  P player could reduce to 1, 
  N player reduce the other tower to 1
  P players is left with no move, N player wins.
  
  Parallel universe with different move
  
  P player reduce to a diferent number,
  N player redice mimic the move to the other tower
  P player reduce to 1
  N player reduce to 1 the other tower.
  P player is left with no moves, N player wins
  
Now escalate to:, when n even towers, N player will win as will mimic the other player moves. 
 

Two players are playing a game of Tower Breakers! The rules of the game are as follows:

- Player  always moves first, and both players always play optimally.
- Initially there are  towers, where each tower is of height .
- The players move in alternating turns. In each turn, a player can choose a tower of height  and reduce its height to , where  and  evenly divides .
- If the current player is unable to make a move, they lose the game.


Given the values of  and , determine which player will win. If the first player wins, return . Otherwise, return .

For example, there are  towers, each  high. Player  can remove  pieces from a tower to leave  as . Player  can also remove  pieces leaving . Let Player  remove . Player  matches the move. Now Player  has only one move: remove  pieces leaving . Player  matches again leaving Player  with no move.

Function Description

Complete the towerBreakers function in the editor below. It should return an integer that represents the winning player.

towerBreakers has the following paramter(s):

n: an integer that represents the number of towers
m: an integer that represents the height of each tower
Input Format

The first line contains a single integer , the number of test cases.
Each of the next  lines describes a test case in the form of  space-separated integers,  and .

Constraints

Output Format

For each test case, if the first player wins, return . Otherwise, return .

Sample Input

2
2 2
1 4
Sample Output

2
1
Explanation

We'll refer to player  as  and player  as 

In the first test case,  chooses one of the two towers and reduces it to . Then  reduces the remaining tower to a height of . As both towers now have height ,  cannot make a move so  is the winner.

In the second test case, there is only one tower of height .  can reduce it to a height of either  or .  chooses  as both players always choose optimally. Because  has no possible move,  wins.
