# Word Counter

## By _Chan Lee_ , Sep 7th, 2018

## Description

This program find occurrences of specified word in given texts. User must enter two type of inputs: word to search/count and text to look for the word.


## Behavior-driven Development

| Specs    |  Input | Output | Rationale   
| ------------- |------------- |------------- |:-------------:|
| Program receives texts and split into word units by creating string array, while ignoring white spaces and punctuations. | I, have a dream!| ["I","have","a","dream"] | (White spaces and punctuations are ignored)
| Program stores both specified word and text (split into word) in lower cases, for case insensitive match. | Free | free | (Data will be a string and string array, each string of word will be lowercased)
| Program returns number of occurrences on given text, just for perfect match | Specified word: Dessert, Text: Dessert Desert Desssert iDessert Desserts  | Occurence: 1 | (Program counts only perfect match)
| Program receives specified word and text | Queen: [4,3] & Other: [3,4] | true


## Setup/Installation Requirements

1. Clone this repository
```
    $ git clone https://github.com/goenchan/WordCount
```
2. Navigate into the directory
```
    $ cd WordCount.Solution/Models/
```
3. Run WordCount.exe


## Known Bugs

None

## Support and contact details

_ChanEthanLee@gmail.com_

## Technologies Used

* Visual Studio
* C#/.Net Core 1.1
* Mono

### Licensed under MIT

### _Chan Lee_ Copyright (c) 2018
