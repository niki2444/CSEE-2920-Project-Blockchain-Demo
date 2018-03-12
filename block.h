#ifndef block_h
#define block_h

#include <cstdlib>
#include <string>
#include <iostream>
#include <cstring>

using namespace std;

class block {

 private:
  string previousHash;
  string blockHash;
  string transactions;
 
 public:
  block();
  block(string previousHash, string transactions);
  string getPreviousHash();
  string getTransactions();
  string getBlockHash();
  void setTransactions(string transactions);
  void setHash(string previousHash, string transactions);
  ~block();

};
#endif
