# Word Counter

## By _Chan Lee_ , Sep 7th, 2018

## Description

This program find occurrences of specified word in given texts. User must enter two type of inputs: word to search/count and text to look for the word.


## Behavior-driven Development

| Specs    |  Input | Output | Rationale   
| ------------- |------------- |------------- |:-------------:|
| Program receives texts and split into word units by creating string array, while ignoring white spaces and punctuations. | "I, have a dream!"| ["I","have","a","dream"] | _(White spaces and punctuations are ignored.)_
| Program stores both specified word and text in lower cases, for case insensitive match. | "Dream" | "dream" | _(Data will be a string and string array, each string of word will be lowercased.)_
| Program returns number of occurrences on given text, just for perfect match | Specified word: Dessert, Text: Dessert Desert Desssert iDessert Desserts  | Occurrence: 1 | _(Program counts only perfect match.)_
| Program detects words inside the given text and store it as a string array | Free at last! | {"free", "at", "last", ""}; | _(Program detects punctuations and space to separate text into words. Note that the last element of array is an empty string, added because of ! character at the end of given text.)_


## Setup/Installation Requirements

1. Clone this repository
```
    $ git clone https://github.com/goenchan/WordCount
```
2. Navigate into the directory
```
    $ cd WordCount.Solution/Models/
```
3. Run WordCount.exe using mono
```
    $ mono WordCounter.exe
```


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
