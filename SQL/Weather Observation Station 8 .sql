SELECT city from station WHERE city REGEXP '^(A|E|I|O|U)+[a-z ]+(a|e|i|o|u)$' ORDER BY city ASC;