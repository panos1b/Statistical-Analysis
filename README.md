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
- Finnaly you can run the programm as follows
`docker run stats_analysis --help`
    - This will bring up the help. Replace `--help` with your arguments and values
## Licence
Licensed under the EUPL \
Take a look at the licence file [EN](https://github.com/panos1b/SEIP-lab/blob/development/LICENCE_EN.txt) and [EL](https://github.com/panos1b/SEIP-lab/blob/development/LICENCE_EL.txt)
