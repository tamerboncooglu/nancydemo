FROM        mono:4.0.1
COPY        . /NancyDemo
WORKDIR     /NancyDemo
RUN         xbuild NancyDemo.sln
EXPOSE      8081
ENTRYPOINT  ["mono", "NancyDemo/bin/NancyDemo.exe"]