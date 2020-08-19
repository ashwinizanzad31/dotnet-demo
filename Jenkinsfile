pipeline {
  agent any
  tools() {
    docker: 'docker'
  }

  stages {
    stage('foo') {
      steps {
        sh "docker version" // DOCKER_CERT_PATH is automatically picked up by the Docker client
      }
    }
  }
}
