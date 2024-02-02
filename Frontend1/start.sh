#!/bin/sh
docker stop frontend1
docker rm frontend1
docker build -t frontend1:v1 .
#docker images
docker run --name frontend1 -d -p 80:80 frontend1:v1
