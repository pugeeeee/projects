const structure = [
    "Hello! ",
    "<br>",
    "I'm ",
    '<strong id="kamote" style="font-size: 65px;">Gerald</strong>',
    "<br>",
    "a Web Developer"
  ];
  
  const containers = document.querySelectorAll(".puge");
  
  let currentContainerIndex = 0;
  let partIndex = 0;
  let charIndex = 0;
  let isDeleting = false;
  
  function typeNext() {
    const container = containers[currentContainerIndex];
    if (!isDeleting) {
      if (partIndex >= structure.length) {
        setTimeout(() => {
          isDeleting = true;
          deleteLast(container);
        }, 5000);
        return;
      }
  
      let part = structure[partIndex];
  
      if (part.startsWith("<")) {
        const tempDiv = document.createElement("div");
        tempDiv.innerHTML = part;
        const node = tempDiv.firstChild;
  
        container.appendChild(node);
  
        const textContent = node.textContent;
        node.textContent = "";
  
        let innerIndex = 0;
        function typeInsideTag() {
          if (innerIndex <= textContent.length) {
            node.textContent = textContent.slice(0, innerIndex);
            innerIndex++;
            setTimeout(typeInsideTag, 60);
          } else {
            partIndex++;
            charIndex = 0;
            setTimeout(typeNext, 100);
          }
        }
  
        typeInsideTag();
      } else {
        const currentText = part.slice(0, charIndex + 1);
        if (!container.lastChild || container.lastChild.nodeType !== 3) {
          container.appendChild(document.createTextNode(""));
        }
        container.lastChild.textContent = currentText;
  
        charIndex++;
        if (charIndex < part.length) {
          setTimeout(typeNext, 60);
        } else {
          partIndex++;
          charIndex = 0;
          setTimeout(typeNext, 100);
        }
      }
    }
  }
  
  function deleteLast(container) {
    const lastNode = container.lastChild;
    if (!lastNode) {
      isDeleting = false;
      partIndex = 0;
      charIndex = 0;
  
      currentContainerIndex = (currentContainerIndex + 1) % containers.length;
      setTimeout(typeNext, 1500);
      return;
    }
  
    if (lastNode.nodeType === 3) {
      const text = lastNode.textContent;
      if (text.length > 0) {
        lastNode.textContent = text.slice(0, -1);
        setTimeout(() => deleteLast(container), 40);
      } else {
        container.removeChild(lastNode);
        setTimeout(() => deleteLast(container), 40);
      }
    } else {
      container.removeChild(lastNode);
      setTimeout(() => deleteLast(container), 40);
    }
  }
  
  window.onload = function () {
    typeNext();
    document.getElementById("sec1").scrollIntoView({ behavior: "smooth" });
  };
  