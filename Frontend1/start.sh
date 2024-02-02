#!/bin/sh
docker stop frontend1 >/dev/null 2>&1
docker rm frontend1 >/dev/null 2>&1
docker image rm frontend1:v1 >/dev/null 2>&1
docker build -t frontend1:v1 .
#docker images
docker run --name frontend1 -d -p 80:80 frontend1:v1
