 def app
pipeline {
    agent any
  tools {
        'org.jenkinsci.plugins.docker.commons.tools.DockerTool'
    }
    stages {
        stage('build') {
            steps {
                  sh 'docker version'
            }
        }
    }
}
