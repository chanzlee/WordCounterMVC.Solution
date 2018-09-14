# Word Counter

#### by _Chan Lee_ , 09/14/2018

## Description

This program find occurrences of specified word in given texts. User must enter two type of inputs: word to search/count and text to look for the word.


## Behavior-driven Development

| Specs    |  Input | Output | Rationale   
| ------------- |:-------------: |:-------------: |:-------------:|
| Program stores specified word in lower cases, for case insensitive match. | "Dream" | _"dream"_ | _(Data will be stored a string each string of word will be lowercased.)_
| Program stores texts in lower cases. | "I HAVE A DREAM!"| _"i have a dream!"_ | _(Text should be also lower cased for case-insensitive match.)_
| Program detects words inside the given text and store it as a string array. | "Free at last!" | _{"free", "at", "last", ""}_ | _(Program detects punctuations and space to separate text into words. Note that the last element of array is an **empty string**, added because of '!' at the end of the text.)_
| Program returns counts only in the case of perfect match. | Word: "Dream" / Text: "Dream Dreaam Drem Dream Dreaming"  | _Match: "Dream"_ | _(Program counts only perfect match.)_
| Program returns final counts to users. | Word: "Free" / Text: "Free at last! Free at last! Thank God Almighty, we are free at last!" | _Count = 3_ | _(return total number of case-insensitive, perfect match.)_


## Setup/Installation Requirements

1. Clone this repository
```
    $ git clone https://github.com/goenchan/WordCount
```
2. Navigate into the directory
```
    $ cd WordCount.Solution/WordCounter/
```
3. Run local hosting through dotnet run
```
    $ dotnet run
```
4. Connect to http://localhost:5000 in web browser.


## Known Bugs

None

## Support and contact details

_ChanEthanLee@gmail.com_

## Technologies Used

* Visual Studio
* C#/.Net Core 1.1
* AspNetCore MVC 1.1.3
* JavaScript
* CSS
* HTML

#### Licensed under MIT

### _Chan Lee_ Copyright (c) 2018
