#pragma once
#include "Node.h"
class LinkedList
{
public: Node *_head;
		Node *_tail;

public: int count = 0;
		LinkedList();
		void AddAfterSecond(float num);	
		void AddInEnd(float num);
		void Remove(float item);
		void Clear();
		bool Contains(float item);
		void PrintList();
		int FindCount(float n);
		void DeleteGreater();
};

