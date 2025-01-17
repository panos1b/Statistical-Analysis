[![Statistical-Analysis .NET](https://github.com/panos1b/Statistical-Analysis/actions/workflows/dotnet.yml/badge.svg)](https://github.com/panos1b/Statistical-Analysis/actions/workflows/dotnet.yml)
[![Statistical-Analysis Docker Image CI](https://github.com/panos1b/Statistical-Analysis/actions/workflows/docker-image.yml/badge.svg)](https://github.com/panos1b/Statistical-Analysis/actions/workflows/docker-image.yml)
# Statistical Analysis
## Description
This repository contains a CLI program which can output basic statistical measures for a set of values
## Usage
#### First Usage:
- First you must clone the project. Navigate to a folder of your choice then run
`git clone https://github.com/panos1b/Statistical-Analysis`
- Then enter to the project folder
`cd Statistical-Analysis`
- Now you must build the docker image
`docker build -t stats_analysis .`
    - Don’t forget the period at the end
- Finally, you can run the program as follows
`docker run stats_analysis --help`
    - This will bring up the help. Replace `--help` with your arguments and values
#### Every subsequent use:
- Directly run the program via docker image whilst in the correct folder \
`docker run stats_analysis [--min] [--max] [--mode] [--mean] [--median] [--individual] [integer1 integer2 ...]`
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
* **Both** will output:
~~~
> The minimum is: 4
> The maximum is: 6
> The median is: 5.5
> The mode is: 6
~~~
___
#### Individual ignores duplicate values
`docker run stats_analysis --mode --individual 4 5 6 7` \
`docker run stats_analysis --mode --individual 4 5 6 7 7 7 7 7`
* **Both** will output:
~~~
> The mode is: 4
~~~

## License
Licensed under the EUPL \
Take a look at the license file [EN](https://github.com/panos1b/Statistical-Analysis/blob/development/LICENCE_EN.txt) and [EL](https://github.com/panos1b/Statistical-Analysis/blob/development/LICENCE_EL.txt)
