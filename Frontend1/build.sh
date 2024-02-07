#!/bin/sh
#
# Distrugge e ricrea l'immagine docker
#
docker stop frontend1 >/dev/null 2>&1
docker rm frontend1 >/dev/null 2>&1
docker image rm frontend1:latest >/dev/null 2>&1
docker build -t frontend1:latest .

# Per ottenere elenco immagini
#docker images

# Per avviare localmente
#docker run --name frontend1 -d -p 80:80 frontend1:latest
