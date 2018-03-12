#include "block.h"
#include "sha256.h"
#include <cstdlib>
#include <iostream>

using namespace std;

block::block(string previousHash, string transactions) {
  this->previousHash = previousHash;
  this->transactions = transactions;
  this->blockHash = sha256(previousHash+transactions);
}

string block::getPreviousHash() {
  return this->previousHash;
}

string block::getTransactions() {
  return this->transactions;
}

string block::getBlockHash() {
  return this->blockHash;
}

void block::setTransactions(string transactions) {
  this->transactions = transactions;
}

void block::setHash(string previousHash, string transactions) {
  this->blockHash = sha256(previousHash + transactions);
}

block::~block() {

}

