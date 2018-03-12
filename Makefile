#Makefile for Blockchain

all: main

main.o: main.cpp
	g++ -c main.cpp

block.o: block.cpp
	g++ -c block.cpp

sha256.o: sha256.cpp
	g++ -c sha256.cpp

main: main.o block.o sha256.o
	g++ main.cpp block.cpp sha256.cpp -o main

clean: 
	rm -f main
	rm -f main.o

	rm -f block
	rm -f block.o	

	rm -f sha256
	rm -f sha256.o