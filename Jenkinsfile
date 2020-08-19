pipeline {
  agent any
  tools(docker: 'docker') {
sh 'docker version'
  }

  stages {
    stage('foo') {
      steps {
        sh "docker version" // DOCKER_CERT_PATH is automatically picked up by the Docker client
      }
    }
  }
}
