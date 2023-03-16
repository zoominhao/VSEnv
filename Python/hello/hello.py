import os
import re
import subprocess
import sys


class PreCommitProcess(object):
    def __init__(self):
        self._init_commit_files()

    def _init_commit_files(self):
        if len(sys.argv) < 2:
            return
        _arg = sys.argv[1]
        #sys.stderr.write(str(_arg) + "\n")
        #sys.exit(1)  


if __name__ == '__main__':
    app = PreCommitProcess()