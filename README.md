# SEIP-lab
## Description
This repository contains the second lab project for the SEIP module. This basic program will produce statistical metrics for a set of integers.
## Usage
- First you must clone the project. Navigate to a folder of your choice then run
`git clone https://github.com/panos1b/SEIP-lab`
- Then enter to the project foler
`cd SEIP-lab`
- Now you must build the docker image
`docker build -t stats_analysis .`
    - Dont forget the period at the end
- Finnaly you can run the programm as follows
`docker run stats_analysis --help`
    - This will bring up the help. Replace `--help` with your arguments and values
## Examples
#### Using a singular argument
~~~
> docker run stats_analysis --max 1 5 7 45 8 4 6 3 2
> The maximum is: 45 
~~~
~~~
> docker run stats_analysis --min 8 6 5 4 6
> The minimum is: 4
~~~
___
#### Using more than one argument
~~~
> docker run stats_analysis --max --min --mode 1 5 7 45 8 4 6 3 2
> The minimum is: 1
> The maximum is: 45
> The mode is: 1
~~~
~~~
> docker run stats_analysis --mode --median --max 8 6 5 4 6
> The maximum is: 8
> The median is: 6
> The mode is: 6
~~~
___
#### Mixing things up is okay!
`docker run stats_analysis --mode 5 --median 6 --max 4 6 --min` \
`docker run stats_analysis --mode --median --max --min 5 6 4 6`
* Both will output:
~~~
> The minimum is: 4
> The maximum is: 6
> The median is: 5.5
> The mode is: 6
~~~

## Licence
Licensed under the EUPL \
Take a look at the licence file [EN](https://github.com/panos1b/SEIP-lab/blob/development/LICENCE_EN.txt) and [EL](https://github.com/panos1b/SEIP-lab/blob/development/LICENCE_EL.txt)
