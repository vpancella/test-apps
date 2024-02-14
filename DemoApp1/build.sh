#!/bin/sh
#
# Distrugge e ricrea l'immagine docker
#
docker stop demoapp1 >/dev/null 2>&1
docker rm demoapp1 >/dev/null 2>&1
docker image rm demoapp1:latest >/dev/null 2>&1
docker build -t demoapp1:latest .

# Per ottenere elenco immagini
#docker images

# Per avviare localmente
#docker run --name demoapp1 -d -p 80:80 demoapp1:latest
