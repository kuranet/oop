#include "LinkedList.h"
#include"Node.h"

#include <iostream>

using namespace std;

LinkedList::LinkedList() {
	_head = NULL;
}

void LinkedList::AddAfterSecond(float num)
{
	Node* node = new Node(num);

	if (_head == NULL) // Add first
	{
		_head = node;
		_tail = node;
	}
	else if (_head->next == NULL) // Add second
	{
		_head->next = node;
		_tail = node;
	}
	else if (_head->next->next == NULL) // Add third
	{
		_head->next->next = node;
		_tail = node;
	}
	else // Add after second
	{
		Node* third = _head->next->next;
		_head->next->next = node;
		_head->next->next->next = third;
	}
	count++;
}
void LinkedList:: AddInEnd(float num)
{
	Node* node = new Node(num);

	if (_head == nullptr)
	{
		_head = node;
		_tail = node;
	}
	else
	{
		_tail->next = node;
		_tail = node;
	}
	count++;
}
void LinkedList:: Remove(float item)
{
	Node* previous = nullptr;
	Node* current = _head;

	while (current != nullptr)
	{
		if (current->value == item)
		{
			// Узел в середине или в конце.
			if (previous != nullptr)
			{
				// Случай 3b.

				// До:    Head -> 3 -> 5 -> null
				// После: Head -> 3 ------> null
				previous->next = current->next;

				// Если в конце, то меняем _tail.
				if (current->next == nullptr)
				{
					_tail = previous;
				}
			}
			else
			{
				// Случай 2 или 3a.

				// До:    Head -> 3 -> 5
				// После: Head ------> 5

				// Head -> 3 -> null
				// Head ------> null
				_head = _head->next;

				// Список теперь пустой?
				if (_head == nullptr)
				{
					_tail = nullptr;
				}
			}
			count--;
		}
		previous = current;
		current = current->next;
	}
}
void LinkedList:: Clear()
{
	_head = nullptr;
	_tail = nullptr;
	count = 0;
}

bool LinkedList:: Contains(float item)
{
	Node* current = _head;
	while (current != nullptr)
	{
		if (current->value == item)
		{
			return true;
		}
		current = current->next;
	}
	return false;
}

void LinkedList:: PrintList()
{
	Node* node = _head;
	while (node != NULL)
	{
		cout << node->value << endl;
		node = node->next;
	}
	cout << endl;
}
int LinkedList:: FindCount(float n)
{
	int k = 0;
	Node* node = _head;

	while (node != nullptr)
	{
		if (node->value > n)
			k++;
		node = node->next;
	}

	return k;
}

void LinkedList:: DeleteGreater()
{
	Node* node = _head;
	float average = 0;

	while (node != nullptr)
	{
		average += node->value;
		node = node->next;
	}

	average /= count;
	cout << "Average: " << average << endl;

	node = _head->next;
	Node* previous = _head;

	while (node != nullptr)
	{
		if (node->value > average)
		{
			previous->next = node->next;
		}
		else
		{
			previous = node;
		}
		node = node->next;
	}

	if (_head->value > average)
		_head = _head->next;
}